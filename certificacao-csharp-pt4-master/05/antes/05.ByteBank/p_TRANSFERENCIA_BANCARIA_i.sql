IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('p_TRANSFERENCIA_BANCARIA_i'))
BEGIN
    DROP PROCEDURE p_TRANSFERENCIA_BANCARIA_i
END
GO
CREATE PROCEDURE p_TRANSFERENCIA_BANCARIA_i
@CONTA_ID_DEBITO INT,
@CONTA_ID_CREDITO INT,
@VALOR DECIMAL
AS
BEGIN
	DECLARE @ERROR_MESSAGE VARCHAR(MAX)

	BEGIN TRY
		BEGIN TRANSACTION
			IF NOT EXISTS(SELECT 1 FROM CONTA WHERE CONTA_ID = @CONTA_ID_DEBITO)
				RAISERROR('CONTA N�O ENCONTRADA!', 11, 1)
			IF NOT EXISTS(SELECT 1 FROM CONTA WHERE CONTA_ID = @CONTA_ID_CREDITO)
				RAISERROR('CONTA N�O ENCONTRADA!', 11, 1)		

			DECLARE @SALDO_DISPONIVEL DECIMAL
			SELECT @SALDO_DISPONIVEL = SALDO_DISPONIVEL FROM CONTA WHERE CONTA_ID = @CONTA_ID_DEBITO;

			IF @SALDO_DISPONIVEL < @VALOR
				RAISERROR('N�O H� FUNDOS SUFICIENTES PARA A TRANSFER�NCIA!', 11, 1)

			INSERT INTO CONTA_TRANSACAO (TRANSACAO_DATA, CONTA_id, TRANSACAO_TIPO_COD, 
			QUANTIA, DATA_FUNDO_DISPONIVEL)
			SELECT GETDATE(), @CONTA_ID_DEBITO, 'TRANSF C/C', -@VALOR, GETDATE()

			INSERT INTO CONTA_TRANSACAO (TRANSACAO_DATA, CONTA_id, TRANSACAO_TIPO_COD, 
			QUANTIA, DATA_FUNDO_DISPONIVEL)
			SELECT GETDATE(), @CONTA_ID_CREDITO, 'TRANSF C/C', @VALOR, GETDATE()

			UPDATE CONTA SET SALDO_DISPONIVEL = SALDO_DISPONIVEL - @VALOR WHERE CONTA_ID = @CONTA_ID_DEBITO;
			UPDATE CONTA SET SALDO_DISPONIVEL = SALDO_DISPONIVEL + @VALOR WHERE CONTA_ID = @CONTA_ID_CREDITO;

			--SELECT * FROM CONTA WHERE CONTA_ID = @CONTA_ID_DEBITO;
			--SELECT * FROM CONTA WHERE CONTA_ID = @CONTA_ID_CREDITO;
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRAN

		SELECT @ERROR_MESSAGE = ERROR_MESSAGE();
		RAISERROR(@ERROR_MESSAGE, 1, 1)
	END CATCH

END
GO
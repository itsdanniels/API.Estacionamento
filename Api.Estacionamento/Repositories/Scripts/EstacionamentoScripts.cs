namespace Api.Estacionamento.Repositories.Scripts
{
    public class EstacionamentoScripts
    {
        internal static string GetVeiculoPorPlaca => @"SELECT
                                                        P.ID,
                                                        P.PLACA,
                                                        P.TP_VEICULO AS TIPO,
                                                        P.DT_ENTRADA AS ENTRADA,
                                                        V.PROPRIETARIO,
                                                        V.COR,
                                                        V.MODELO,
                                                        TP.VALOR_HR AS VALOR
                                                    FROM VEICULOS AS V
                                                    INNER JOIN PATIO AS P ON V.PLACA = P.PLACA
                                                    INNER JOIN TIPOS_VEICULO AS TP ON V.TP_VEICULO = TP.ID
                                                    WHERE V.PLACA = @Placa
                                                    AND FINALIZADO = 'N'";

        internal static string CadastrarVeiculoNoPatio => @"INSERT PATIO
                                                            VALUES ( @Placa, @Tipo, GETDATE(), NULL, 'N', NULL)
                                                            INSERT VEICULOS
                                                            VALUES ( @Placa, @Tipo, @Proprietario, @Modelo, @Cor)";

        internal static string CadastrarSaidaVeiculo => @"";
    }
}

namespace Api.Estacionamento.Repositories.Scripts
{
    public class EstacionamentoScripts
    {
        internal static string GetVeiculoPorId => @"SELECT * FROM ESTACIONAMENTO..VEICULOS
                                                    WHERE ID = @Id";

        internal static string CadastrarVeiculoNoPatio => @"INSERT PATIO
                                                            VALUES ( @Placa, @Tipo, GETDATE(), NULL, 'N', NULL)
                                                            INSERT VEICULOS
                                                            VALUES ( @Placa, @Tipo, @Proprietario, @Modelo, @Cor)";
    }
}

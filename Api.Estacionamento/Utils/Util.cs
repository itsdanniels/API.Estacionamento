namespace Api.Estacionamento.Utils
{
    public static class Util
    {
        public static string Formatplaca(string placa)
        {
            if(placa.Contains('-'))
            {
                return placa.Remove('-');
            }
            return placa;
        }
    }
}

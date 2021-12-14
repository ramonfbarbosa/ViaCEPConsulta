namespace ViaCEPConsulta.DTO
{
    class ViaCEPDTO
    {
        public string State { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }

        public ViaCEPDTO()
        {
        }
        public ViaCEPDTO(string state, string city, string district, string address)
        {
            State = state;
            City = city;
            District = district;
            Address = address;
        }

        public override string ToString()
        {
            return "\n" +
                "Estado: " + State +
                "\n" +
                "Cidade: " + City +
                "\n" +
                "Bairro: " + District +
                "\n" +
                "Endereço: " + Address;
        }
    }
}

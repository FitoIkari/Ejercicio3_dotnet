public struct Client {
    public string FullName { get; }
    public string Phone { get; }
    public string Address { get; }
    public string Email { get; }
    public bool NewClient { get; }
    public Client(string fullName, string phone, string address, string email, bool newClient) {
        FullName = fullName;
        Phone = phone;
        Address = address;
        Email = email;
        NewClient = newClient;
    }

    public override string ToString() {
        return $"El usuario {FullName} {(NewClient ? " " : "no")} es un cliente nuevo.\n" +
            $"A continuación se muestra la información del usuario: \n" +
            $"- Teléfono: {Phone}\n" +
            $"- Dirección: {Address}\n" +
            $"- Email: {Email}\n";
    }
}

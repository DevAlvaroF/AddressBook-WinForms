namespace MainProgram.Models
{
    internal class ContactModel
    {
        public int ID { get; set; }
        public string Date_Added { get; set; }
        public string? Company { get; set; }
        public string? Website { get; set; }
        public string? Title { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Postal_Code { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Notes { get; set; }
        public byte[]? Image { get; set; }
    }
}

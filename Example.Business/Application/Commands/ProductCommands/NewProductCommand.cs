namespace Example.Business.Application.Commands.ProductCommands
{
    public class NewProductCommand : ICommand
    {
        public NewProductCommand(string name, decimal unitPrice)
        {
            this.Name = name;
            this.UnitPrice = unitPrice;
        }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

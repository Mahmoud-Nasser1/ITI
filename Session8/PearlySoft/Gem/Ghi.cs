namespace Gem
{
    public class Ghi
    {
        ////Assigned from anywhere
        //public int Id { get; set; } = 1010;

        ////Assied from anywhere in its containing type (class)
        //public string Name { get; private set; } = "S 15";

        ////Read-only property (doesn't have set accessor)
        ////Assigned from Initialization & Constructor
        //public string Description { get; } = "Tablet";

        ////Init-only property (has init instead of set)
        ////Assigned from Initialization & Constructor & Object Initializer
        //public decimal Price { get; init; } = 13500.25m;

        //public Ghi()
        //{
        //    Id = 1020;
        //    Name = "T 17";
        //    Description = "Samsung Tablet";
        //    Price = 14000.75m;
        //}

        //public void Test()
        //{
        //    Id = 1030;
        //    Name = "M 13";
        //    Description = "Abc Tablet";
        //    Price = 14750.25m;
        //}
    }
}
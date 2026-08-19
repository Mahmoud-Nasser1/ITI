using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gem
{
    //A record is a type whose primary purpose is to
    //represent data rather than behavior.
    //    متى تستخدم الـ Record؟
    //DTOs(Data Transfer Objects) : لنقل البيانات بين الطبقات المختلفة(مثل API responses).

    //Read-Only Data: لما تكون شغال على بيانات ثابته مش محتاج تعدل فيها بعد إنشائها.

    //Value-like Objects: لما تحتاج تقارن الكائنات بناءً على محتواها وقيمها مش على مكانها في الذاكرة.


    public record Department(int Id, string Name,
        string Description, decimal Budget);

    //public class Department
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public decimal Budget { get; set; }

    //    public Department(int id, string name,
    //        string description, decimal budget)
    //    {
    //        Id = id;
    //        Name = name;
    //        Description = description;
    //        Budget = budget;
    //    }
    //}
}
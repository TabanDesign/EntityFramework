namespace RelationOneToMany.Models
{
    public class State
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        /// <summary>
        ///  کلاسی که چندتاس و میخاهد به یکی رابطه برقرار کند یک پراپرتی تکی را ادد میکنیم
        ///  ویرچوال کاره لیزی لودینگ را انجام میدهد
        /// </summary>
        public virtual Country Country { get; set; }
        public State()
        {

        }
    }
}

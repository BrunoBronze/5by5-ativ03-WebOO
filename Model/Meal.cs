namespace Model
{
    public class Meal
    {
        public const string select = "SELECT Id, Description, Value FROM TB_MEAL";
        public const string insert = "INSERT INTO TB_MEAL VALUES ({0})";
        public const string remove = "DELETE FROM TB_MEAL WHERE Id = {0}";
        public const string selectTotal = "SELECT Valor FROM TB_MEAL WHERE Id = {0}";

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public Pizza Pizza { get; set; }

        public override string ToString()
        {
            return $"'{Description}',{Value:F2}";
        }
    }
}

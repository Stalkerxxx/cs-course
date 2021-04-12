namespace homeWork10
{
    class Person 
    {
        public string Name { get; set; } 
        public byte Age { get; set; }
        public byte AgeFourYears() 
        {
            var age = (byte)(Age + 4);
            return age;
        }
        public string Discription =>
            $"{Name} will be born in four years: {Age + 4}";
    }
}

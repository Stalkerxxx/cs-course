namespace homeWork10
{
    class Person 
    {
        public string Name { get; set; } 
        public byte Age { get; set; }
        public string Discription =>
            $"{Name} will be born in four years: {Age + 4}";
    }
}

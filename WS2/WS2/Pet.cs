namespace WS2
{
    public class Pet
    {
        private string color;
        private string name;
        private string type;

        public Pet(string color, string name, string type)
        {
            this.color = color;
            this.name = name;
            this.type = type;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            return "Pet:\nname: " + name + "\ncolor: " + color + "\ntype: " + type;
        }
    }
}
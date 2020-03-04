namespace SMDR.Infratructure.Base
{
    public class Column
    {
        public Column()
        {

        }
        public Column(string name, int start, int length) : this()
        {
            this.Name = name;
            this.StartIndex = start;
            this.Length = length;
        }
        public Column(string name, int start, int length, int spaceAfter) : this(name, start, length)
        {
            this.SpaceAfter = spaceAfter;
        }
        public int StartIndex { get; set; }
        public int SpaceAfter { get; set; } = 1;
        public int Length { get; set; }
        public string Name { get; set; }
    }

}

using D_DTesting.Domain.Abstractions;

namespace D_DTesting.Domain.Model.Misc
{
    public class Property
    {
        public string Name { get; set; }
        public IType Type {  get; set; }
        public string Description { get; set; }
        public int Modifier { get; set; }
        public bool Advantage { get; set; }
        public bool Disadvantage { get; set; }
        public int Proficiency { get; set; }
    }
}

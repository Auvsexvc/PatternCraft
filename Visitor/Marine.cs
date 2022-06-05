namespace Visitor
{
    public class Marine : ILightUnit
    {
        public int Health { get; set; } = 100;

        public Marine()
        {
            Health = 100;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitLight(this);
        }
    }
}
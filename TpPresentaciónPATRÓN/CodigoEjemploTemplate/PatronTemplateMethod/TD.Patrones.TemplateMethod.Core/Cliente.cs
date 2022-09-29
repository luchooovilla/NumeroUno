namespace TD.PatronesTemplateMethod.Core
{
    public class Cliente
    {
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
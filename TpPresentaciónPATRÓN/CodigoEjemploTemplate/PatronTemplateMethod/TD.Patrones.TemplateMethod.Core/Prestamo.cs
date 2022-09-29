
namespace TD.PatronesTemplateMethod.Core
{
    public abstract class Prestamo : Validaciones
    {
        public Prestamo(Cliente c)
        {
            _cliente = c;
        }

        protected abstract  override string VerificarAcciones();
        protected abstract  override string VerificarBalance();
        protected abstract  override string VerificarIngresos();
        protected abstract  override string VerificarPrestamos();
    }
}
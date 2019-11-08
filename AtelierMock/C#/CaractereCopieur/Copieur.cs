namespace CaractereCopieur
{
    public class Copieur
    {
        private Interfaces.ISource _source;
        private Interfaces.IDestination _destination;

        public Copieur(Interfaces.ISource source, Interfaces.IDestination destination)
        {
            _source = source;
            _destination = destination;
        }


        public void Copier()
        {
        }
    }
}

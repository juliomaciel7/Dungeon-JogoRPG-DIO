

namespace Domain.Entities
{
    public abstract class Hero
    {
        public int HeroiId { get; private set; }
        public string Nome { get; private set; }
        public int Nivel { get; private set; }
        public string TipoDoHeroi { get; private set; }

        public Hero()
        {

        }

        public Hero(string nome, int nivel, string tipoDoHeroi)
        {
            Validation(nome, nivel, tipoDoHeroi);
        }

        public Hero(int heroiId, string nome, int nivel, string tipoDoHeroi)
        {
            if (heroiId <= 0)
                throw new InvalidOperationException("O id não pode ser zero ou negativo");

            HeroiId = heroiId;

            Validation(nome, nivel, tipoDoHeroi);
        }

        private void Validation(string nome, int nivel, string tipoDoHeroi)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentNullException("O nome não pode ser nulo ou vazio!");

            Nome = nome;

            if (nivel < 0)
                throw new InvalidOperationException("O nível não pode ser negativo!");

            Nivel = nivel;

            if (string.IsNullOrEmpty(tipoDoHeroi))
                throw new ArgumentNullException("O tipo do herói não pode ser nulo ou vazio!");

            TipoDoHeroi = tipoDoHeroi;
        }

        public abstract string Atacar();
       
    }
}

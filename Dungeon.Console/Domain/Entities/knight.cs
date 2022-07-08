
namespace Domain.Entities
{
    public sealed class knight : Hero
    {
        public knight()
        {
        }

        public knight(string nome, int nivel, string tipoDoHeroi) : base(nome, nivel, tipoDoHeroi)
        {
        }

        public knight(int heroiId, string nome, int nivel, string tipoDoHeroi) : base(heroiId, nome, nivel, tipoDoHeroi)
        {

        }

        public override string Atacar()
        {
            return $"O cavaleiro {Nome} ataca com um golpe de  espada!";
        }
    }
}


namespace Domain.Entities
{
    public sealed class Ninja : Hero
    {
        public Ninja()
        {
        }

        public Ninja(string nome, int nivel, string tipoDoHeroi) : base(nome, nivel, tipoDoHeroi)
        {
        }

        public Ninja(int heroiId, string nome, int nivel, string tipoDoHeroi) : base(heroiId, nome, nivel, tipoDoHeroi)
        {

        }

        public override string Atacar()
        {
            return $"O ninja {Nome} ataca com chute e golpe de espada!";
        }
    }
}


namespace Domain.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard()
        {
        }

        public BlackWizard(string nome, int nivel, string tipoDoHeroi) : base(nome, nivel, tipoDoHeroi)
        {
        }

        public BlackWizard(int heroiId, string nome, int nivel, string tipoDoHeroi) : base(heroiId, nome, nivel, tipoDoHeroi)
        {

        }

        public override string Atacar()
        {
            return $"O mago {Nome} ataca com magia tipo black!";
        }
    }
}

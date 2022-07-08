

namespace Domain.Entities
{
    public sealed class WhiteWizard : Hero
    {
        public WhiteWizard()
        {
        }

        public WhiteWizard(string nome, int level, string tipoDoHeroi) : base(nome, level, tipoDoHeroi)
        {

        }

        public WhiteWizard(int heroiId, string nome, int nivel, string tipoDoHeroi) : base(heroiId, nome, nivel, tipoDoHeroi)
        {
        }

        public override string Atacar()
        {
            return $" O Mago Branco {Nome} ataca com magia tipo white!";
        }
    }
}

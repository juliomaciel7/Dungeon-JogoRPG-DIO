

namespace Domain.Entities.Factory
{
    public sealed class HeroSimpleFactory
    {
        public static Hero CriarHeroi(string nomeHeroi)
        {
            Hero hero;
            switch (nomeHeroi)
            {
                case "1":
                    hero = new knight("Arus", 23, "Cavaleiro");
                    break;
                case "2":
                    hero = new Ninja("Wedge", 42, "Ninja");
                    break;
                case "3":
                    hero = new WhiteWizard("Jenica", 39, "Mago Branco");
                    break;
                case "4":
                    hero = new BlackWizard("Topapa", 41, "Mago Negro");
                    break;
                default:
                    throw new Exception("Erro ao criar Herói!");
            }

            if (hero == null)
                throw new ArgumentNullException("Não pode ser nulo");

            return hero;
        }
    }
}

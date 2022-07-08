

using Domain.Entities;
using Domain.Entities.Factory;

Console.WriteLine("\n\t\t\t ****** Dungeon - Jogo RPG ***********\n");
Console.WriteLine(@$"
        Esse jogo possui 4 personagens.

        Cada um é de uma categoria diferente.

        Aurus é cavaleiro e o seu ataque é feito com espada.

        Wedge é ninja e seu ataque é um golpe mais a espada.

        Jenica é mago branco e seu ataque é magia.

        Topapa é mago negro e seu ataque é magia.

");

Console.WriteLine("\n Escolha um herói");
Console.WriteLine("\n 1 - Arus");
Console.WriteLine("\n 2 - Wedge");
Console.WriteLine("\n 3 - Jenica");
Console.WriteLine("\n 4 - Topapa");
var nomeEscolhido = Console.ReadLine();

Console.Clear();
try
{
    Hero hero = HeroSimpleFactory.CriarHeroi(nomeEscolhido);
    Console.WriteLine($@"
         Nome herói escolhido: {hero.Nome}
         Tipo herói: {hero.TipoDoHeroi}
         Nível: {hero.Nivel}
         Ataque: {hero.Atacar()}
");
    

}
catch (Exception)
{
    throw;
}

Console.WriteLine("Aperte Enter para sair");
Console.ReadLine();
using System;
using NUnit.Framework;

    [TestFixture]
public class HeroRepositoryTests
{
    private Hero hero;
    private HeroRepository heroesRep;
    [SetUp]
    public void SetUp()
    {
        hero = new Hero("Gosho" , 3);
        heroesRep = new HeroRepository();
    }
    
    [Test]
    public void HeroConstructorTest()
    {
        string name = "Pesho";
        int level = 5;

        Hero hero = new Hero(name,level);

        Assert.AreEqual(hero.Name, name);
        Assert.AreEqual(hero.Level, level);
    }

   [Test]
   public void ConstructorHeroRepShouldWorkCorrectly()
    {
        HeroRepository heroes = new HeroRepository();

        Assert.IsNotNull(heroes);
    }

    [Test]
    public void CreateMethodShouldThrowExceptionIfHeroIsNull()
    {
        hero = null;

       var exMessage = Assert.Throws<ArgumentNullException>(()
            => heroesRep.Create(hero));

        var expectedMessage = "Hero is null (Parameter 'hero')";
        Assert.AreEqual(exMessage.Message, expectedMessage);
    }

    [Test]
    public void CreateMethodShouldThrowExIfHeroAlreadyExist()
    {
        heroesRep.Create(hero);

        var exMessage = Assert.Throws<InvalidOperationException>(()
            => heroesRep.Create(hero));

        var expectedMessage= $"Hero with name {hero.Name} already exists";

        Assert.AreEqual(exMessage.Message, expectedMessage );
    }

    [Test]
    public void CreateMethodShouldWorkCorrectly()
    {
        heroesRep.Create(hero);

        Assert.AreEqual(heroesRep.Heroes.Count, 1);
    }

    [Test]
    public void RemoveMethodShouldThrowExIfArgumentIsNull()
    {
        heroesRep.Create(hero);
        string name = null;

      var exMessage =  Assert.Throws<ArgumentNullException>(()
            =>heroesRep.Remove(name));

        var expectedMessage = "Name cannot be null (Parameter 'name')";
        Assert.AreEqual(exMessage.Message, expectedMessage );
    }

    [Test]
    public void RemoveMethodShouldWorkProperly()
    {
        heroesRep.Create(hero);
        heroesRep.Create(new Hero("Mincho", 8));
        heroesRep.Create(new Hero("Pepi",3));

        string name = "Mincho";
        heroesRep.Remove(name);

        Assert.AreEqual(heroesRep.Heroes.Count, 2);
    }

    [Test]
    public void GetHeroWithHighestLevelMethodShouldWorkCorrectly()
    {
        Hero highLevelHero = new Hero("Highest Level", 101);
        heroesRep.Create(hero);
        heroesRep.Create(new Hero("Mincho", 8));
        heroesRep.Create(new Hero("Pepi", 3));
        heroesRep.Create(highLevelHero);

       var superHero = heroesRep.GetHeroWithHighestLevel();

        Assert.AreEqual(superHero, highLevelHero);
    }

    [Test]
    public void GetHeroShouldWorkCorrectly()
    {
        string searchedHero = "Gosho";
        heroesRep.Create(hero);
        heroesRep.Create(new Hero("Mincho", 8));
        heroesRep.Create(new Hero("Pepi", 3));

        var foundHero = heroesRep.GetHero(searchedHero);

        Assert.AreEqual(hero, foundHero);
    }

    [Test]
    public void TestHeroesProperty()
    {
        heroesRep.Create(hero);
        heroesRep.Create(new Hero("Mincho", 8));
        heroesRep.Create(new Hero("Pepi", 3));

        Assert.AreEqual(3, heroesRep.Heroes.Count);
    }
}
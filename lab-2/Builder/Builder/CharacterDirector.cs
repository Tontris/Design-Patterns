public class CharacterDirector
{
    private ICharacterBuilder _builder;

    public CharacterDirector(ICharacterBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructHero()
    {
        _builder.SetHeight(183)
                .SetBuild("Athletic")
                .SetHairColor("Brown-haired")
                .SetEyeColor("brown")
                .SetClothing("Armor of the Armed Forces of Ukraine")
                .SetInventory(new List<string> { "HIMARS", "Patriot" })
                .AddGoodDeed("Defense of Ukraine")
                .AddGoodDeed("Destruction of the rashka");
    }

    public void ConstructEnemy()
    {
        _builder.SetHeight(160)
                .SetBuild("Weak")
                .SetHairColor("Black")
                .SetEyeColor("Red")
                .SetClothing("Nothing")
                .SetInventory(new List<string> { "Branches", "Stones" })
                .AddEvilDeed("Destroy Ukraine")
                .AddEvilDeed("To take over Europe");
    }
}
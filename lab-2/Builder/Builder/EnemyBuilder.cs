using System.Collections.Generic;

public class EnemyBuilder : ICharacterBuilder
{
    private Character _character = new Character();

    public ICharacterBuilder SetHeight(double height)
    {
        _character.Height = height;
        return this;
    }

    public ICharacterBuilder SetBuild(string build)
    {
        _character.Build = build;
        return this;
    }

    public ICharacterBuilder SetHairColor(string hairColor)
    {
        _character.HairColor = hairColor;
        return this;
    }

    public ICharacterBuilder SetEyeColor(string eyeColor)
    {
        _character.EyeColor = eyeColor;
        return this;
    }

    public ICharacterBuilder SetClothing(string clothing)
    {
        _character.Clothing = clothing;
        return this;
    }

    public ICharacterBuilder SetInventory(List<string> inventory)
    {
        _character.Inventory = inventory;
        return this;
    }

    public ICharacterBuilder AddGoodDeed(string deed)
    {
        return this;
    }

    public ICharacterBuilder AddEvilDeed(string deed)
    {
        if (_character.EvilDeeds == null)
        {
            _character.EvilDeeds = new List<string>();
        }
        _character.EvilDeeds.Add(deed);
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}
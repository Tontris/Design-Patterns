﻿using System.Collections.Generic;

public class HeroBuilder : ICharacterBuilder
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
        if (_character.GoodDeeds == null)
        {
            _character.GoodDeeds = new List<string>();
        }
        _character.GoodDeeds.Add(deed);
        return this;
    }

    public ICharacterBuilder AddEvilDeed(string deed)
    {
        // Герой не може мати злих справ
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}
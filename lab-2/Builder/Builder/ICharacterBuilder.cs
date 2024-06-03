public interface ICharacterBuilder
{
    ICharacterBuilder SetHeight(double height);
    ICharacterBuilder SetBuild(string build);
    ICharacterBuilder SetHairColor(string hairColor);
    ICharacterBuilder SetEyeColor(string eyeColor);
    ICharacterBuilder SetClothing(string clothing);
    ICharacterBuilder SetInventory(List<string> inventory);
    ICharacterBuilder AddGoodDeed(string deed);
    ICharacterBuilder AddEvilDeed(string deed);
    Character Build();
}

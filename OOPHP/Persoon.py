class Persoon:
  def __init__(self, naam, leeftijd, geslacht, is_student, gemiddeld_cijfer):
    self.naam = naam
    self.leeftijd = leeftijd
    self.geslacht = geslacht
    self.is_student = is_student
    self.gemiddeld_cijfer = gemiddeld_cijfer

  def __str__(self):
    return f"Naam: {self.naam}\nLeeftijd: {self.leeftijd}\nGeslacht: {self.geslacht}\nStudent: {'Ja' if self.is_student else 'Nee'}\nGemiddeld cijfer: {self.gemiddeld_cijfer}"

persoon1 = Persoon("Stefan Milovic", 25, "M", True, 7.2)
persoon2 = Persoon("Joey Fleming", 30, "M", False, 6.5)
persoon3 = Persoon("Poka Hontas", 22, "V", True, 8.1)

print(persoon1)
print(persoon2)
print(persoon3)
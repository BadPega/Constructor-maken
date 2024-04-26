<?php 
class Persoon {
    private $naam;
    private $leeftijd;
    private $geslacht;
    private $isStudent;
    private $gemiddeldCijfer;
  
    public function __construct($naam, $leeftijd, $geslacht, $isStudent, $gemiddeldCijfer) {
      $this->naam = $naam;
      $this->leeftijd = $leeftijd;
      $this->geslacht = $geslacht;
      $this->isStudent = $isStudent;
      $this->gemiddeldCijfer = $gemiddeldCijfer;
    }
}

 $persoon1 = new Persoon("Stefan Milovic", 25, "M", true, 7.2);
 $persoon2 = new Persoon("Joey Fleming", 30, "M", false, 6.5);
 $persoon3 = new Persoon("Poka hontas", 22, "V", true, 8.1);

 echo $persoon1 . "\n";
 echo $persoon2 . "\n";
 echo $persoon3 . "\n";
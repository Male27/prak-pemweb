<?php
// Nama : Maleakhi Pratama Tobing
// NIM  : 121140225
// Kelas Praktikum : RB
class Biodata {
  public $name;
  public $umur;
  public $prodi;
  public $nim;
  public $hobi;

  function setBiodata($name, $umur, $prodi, $nim, $hobi) {
    $this->name = $name;
    $this->umur = $umur;
    $this->prodi = $prodi;
    $this->nim = $nim;
    $this->hobi = $hobi;
  }

  function getBiodata() {
    return "Nama Mahasiswa: " . $this->name . ", Umur: " . $this->umur . ", Prodi: " . $this->prodi . ", NIM: " . $this->nim . ", Hobi: " . $this->hobi;
  }
}

$biodata1 = new Biodata();
$biodata1->setBiodata("Maleakhi", 20, "Teknik Informaatika", 121140225, "Turu");
echo $biodata1->getBiodata();
?>
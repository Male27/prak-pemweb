<!-- by Maleakhi Pratama Tobing - 1212140225-->
<!-- Praktikum Pemrograman Web RB - Tugas 1 -->

<html lang="id"> <!--ini ciri file html -->

<head>
    <title>Judul</title>
</head>

<body>
    <img src="Banner_YT.png" alt="ini gambar" width="200" height="200">
    <h1>Ini, Maleakhi</h1>
    <p></p>
    <ul> <!--list tidak berurut-->
        <li><a href="https://github.com">Kampus saya</a></li>
        <li><a href="https://if.itera.ac.id">Prodi saya</a></li>
        <li><a href="https://youtube.com">Kampus saya</a></li>
    </ul>
    <ol>
        
    </ol>
    <h2>Deskripsi</h2>
    <p>Nama saya Maleakhi Pratama, prodi teknik informatika angkatan 2021, asal daerah Lampung tepatnya Bandarlampung.</p>
    <video src="video_animasi.mp4" width="300" controls></video>
    <audio src="musik.mp3" controls></audio>
    <table border="1">
        <tr>
            <th rowspan="2">No</th>
            <th rowspan="2">Nama</th>
            <th rowspan="2">Prodi</th>
            <th colspan="2">Angkatan</th>
        </tr>
        <tr>
            
        </tr>
        <tr>
            <td>1</td>
            <td>Maleakhi</td>
            <td>Teknik Informatika</td>
            <td>2021</td>
        </tr>
    </table>
    <form action="jawaban.php" method="POST">
        <h2>Hubungi saya</h2>
        <label for="email">email</label> :
        <input type="text" placeholder="masukkan teks" id="email">
        <p>Apakah kaki ada 2?</p>
        <input type="radio" name="soal_b"> Yoi <br>
        <input type="radio" name="soal_b"> No <br>
        <h2>Apa itu?</h2>
        <input type="checkbox" name="a" id="a" value="1"> ini <br>
        <input type="checkbox" name="a" id="a" value="2"> itu <br>
        <input type="checkbox" name="a" id="a" value="3"> anu <br>
        <button type="submit">Kirim</button>
    </form>
</body>

</html>
-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Inang: 127.0.0.1
-- Waktu pembuatan: 13 Jan 2019 pada 14.53
-- Versi Server: 5.1.41
-- Versi PHP: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Basis data: `db_kasir`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `belibarang`
--

CREATE TABLE IF NOT EXISTS `belibarang` (
  `NO` double NOT NULL,
  `TanggalBeli` varchar(20) NOT NULL,
  `NamaPesanan` varchar(25) NOT NULL,
  `Jenis` varchar(20) NOT NULL,
  `TotalBarang` int(5) NOT NULL,
  `Satuan` varchar(9) NOT NULL,
  `HargaSatuan` double NOT NULL,
  `HargaBeli` double NOT NULL,
  PRIMARY KEY (`NO`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `daftarharga`
--

CREATE TABLE IF NOT EXISTS `daftarharga` (
  `Kode` varchar(10) NOT NULL,
  `TanggalBeli` varchar(10) NOT NULL,
  `Jenis` varchar(15) NOT NULL,
  `NamaBarang` varchar(20) NOT NULL,
  `Satuan` varchar(5) NOT NULL,
  `Banyak` double NOT NULL,
  `HargaSatuan` double NOT NULL,
  `HargaJual` double NOT NULL,
  PRIMARY KEY (`Kode`),
  UNIQUE KEY `NoFaktur` (`Kode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `daftarharga`
--

INSERT INTO `daftarharga` (`Kode`, `TanggalBeli`, `Jenis`, `NamaBarang`, `Satuan`, `Banyak`, `HargaSatuan`, `HargaJual`) VALUES
('10003', '30/08/2018', 'Others', 'Daun Pisang', 'ikat', 1, 5000, 10000),
('10001', '30/08/2018', 'Fruit', 'Pisang', 'ikat', 1, 5500, 10000),
('10002', '01/09/2018', 'Vegetables', 'Kol', 'kg', 1, 8000, 15000),
('10004', '01/09/2018', 'Fruit', 'apel', 'kg', 1, 5000, 10000),
('10005', '30/08/2018', 'Vegetables', 'Daun Bawang', 'kg', 1, 3000, 7000),
('10006', '30/08/2018', 'Fruit', 'Lidah Buaya', 'kg', 1, 5000, 10000),
('10007', '11/09/2018', 'Vegetables', 'Kemangi', 'Kg', 0, 5000, 8000),
('10008', '16/09/2018', 'Fruit', 'Ceri', 'kg', 1, 6000, 15000),
('10009', '29/08/2018', 'Fruit', 'Semangka', 'kg', 1, 10000, 15000),
('10010', '20/12/2018', 'Others', 'Gula Pasir', 'kg', 1, 10000, 15000),
('10011', '20/12/2018', 'Others', 'Gula Merah', 'kg', 1, 12000, 20000),
('10012', '20/12/2018', 'Others', 'Kacang Tanah', 'kg', 1, 12000, 20000),
('10013', '20/12/2018', 'Others', 'Telur Ayam', 'kg', 1, 17000, 25000),
('10014', '20/12/2018', 'Others', 'Daging Ayam', 'ekor', 1, 38000, 50000),
('10015', '20/12/2018', 'Others', 'Daging Sapi', 'kg', 1, 95000, 125000),
('10016', '20/12/2018', 'Vegetables', 'Cabe Merah Besar', 'kg', 1, 15000, 30000),
('10017', '20/12/2018', 'Vegetables', 'Cabe Rawit Merah', 'kg', 1, 10000, 17000),
('10018', '20/12/2018', 'Vegetables', 'Cabe Merah Keriting', 'kg', 1, 10000, 17000),
('10019', '20/12/2018', 'Vegetables', 'Cabe Rawit Hijau', 'kg', 1, 13000, 17000),
('10020', '20/12/2018', 'Vegetables', 'Wortel', 'kg', 1, 8000, 16000),
('10021', '20/12/2018', 'Vegetables', 'Terong', 'kg', 1, 8000, 15000),
('10022', '20/12/2018', 'Vegetables', 'Ketimun', 'kg', 1, 7000, 13000),
('10023', '20/12/2018', 'Vegetables', 'Bawang Bombay', 'kg', 1, 30000, 45000),
('10024', '20/12/2018', 'Vegetables', 'Tomat', 'kg', 1, 7000, 15000),
('10025', '20/12/2018', 'Vegetables', 'Sawi', 'kg', 1, 7000, 13000),
('10026', '20/12/2018', 'Vegetables', 'Daun Seledri', 'kg', 1, 10000, 15000),
('10027', '20/12/2018', 'Fruit', 'Jagung', 'kg', 1, 10000, 20000),
('10028', '20/12/2018', 'Fruit', 'Jeruk Limo', 'kg', 1, 20000, 27000),
('10029', '20/12/2018', 'Vegetables', 'Kacang Panjang', 'kg', 1, 15000, 25000),
('10030', '20/12/2018', 'Vegetables', 'Bawang Merah', 'kg', 1, 15000, 25000),
('10031', '20/12/2018', 'Vegetables', 'Kentang', 'kg', 1, 15000, 25000),
('10032', '20/12/2018', 'Vegetables', 'Pisang Thai', 'kg', 1, 20000, 30000),
('10033', '20/12/2018', 'Fruit', 'Mangga', 'kg', 1, 20000, 35000),
('10034', '20/12/2018', 'Fruit', 'Nanas', 'kg', 1, 7000, 15000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `laporankeuangan`
--

CREATE TABLE IF NOT EXISTS `laporankeuangan` (
  `NoPesanan` varchar(25) NOT NULL,
  `TanggalPesanan` varchar(10) NOT NULL,
  `NamaOutlet` varchar(20) NOT NULL,
  `Items` double NOT NULL,
  `BiayaTambahan` double NOT NULL,
  `KetTambahan` varchar(150) NOT NULL,
  `TotalBelanja` double NOT NULL,
  `Penjualan` double NOT NULL,
  `Keuntungan` double NOT NULL,
  `Refund` float NOT NULL,
  `Keterangan` varchar(20) NOT NULL,
  PRIMARY KEY (`NoPesanan`),
  UNIQUE KEY `NoPesanan` (`NoPesanan`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `laporankeuangan`
--

INSERT INTO `laporankeuangan` (`NoPesanan`, `TanggalPesanan`, `NamaOutlet`, `Items`, `BiayaTambahan`, `KetTambahan`, `TotalBelanja`, `Penjualan`, `Keuntungan`, `Refund`, `Keterangan`) VALUES
('100818JAY1636', '06/01/2019', 'Jaya Baya', 11, 75000, 'Gaji Karyawan: 50000 Makan: 15000 Bensin: 10000 ', 683500, 1182000, 498500, 0, 'LUNAS'),
('100930BIS1860', '06/01/2019', 'Bisnis Sentosa', 10, 30000, 'Bensin: 30000 ', 539000, 961000, 392000, 0, 'LUNAS'),
('100660SEN1320', '06/01/2019', 'sentosa', 2, 10000, 'Bensin: 10000 ', 62000, 115000, 43000, 0, 'LUNAS'),
('100384ADI768', '05/01/2019', 'Adipura Jaya Hotel', 10, 10000, 'Transportasi: 10000 ', 772000, 1245000, 463000, 0, 'LUNAS'),
('100889MEK1778', '05/01/2019', 'Mekar Sari Comp', 10, 70000, 'Gaji Karyawan: 50000 Makan: 20000 ', 1147500, 1670000, 452500, 7, 'LUNAS');

-- --------------------------------------------------------

--
-- Struktur dari tabel `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `unsername` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `nama` varchar(20) DEFAULT NULL,
  `perusahaan` varchar(25) NOT NULL,
  `alamat` varchar(100) DEFAULT NULL,
  `telepon` varchar(20) DEFAULT NULL,
  `email` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`unsername`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `login`
--

INSERT INTO `login` (`unsername`, `password`, `nama`, `perusahaan`, `alamat`, `telepon`, `email`) VALUES
('budijulian', '123', 'budi julian', 'PT. Sentosa Jaya Makmur B', 'Jln. Tanah Surga No.3 RT 03/RW 007 Kel. Rambutan Kec.', '088', 'budijulian96@gmail.com'),
('budijulian96', 'budijulian', 'julian', 'pt makmur sentosa', 'jln. tamrin no3 jakarta pusat', '082311526349', 'budijulian96@gmail.com');

-- --------------------------------------------------------

--
-- Struktur dari tabel `order`
--

CREATE TABLE IF NOT EXISTS `order` (
  `NoTransaksi` varchar(20) NOT NULL,
  `TanggalPesanan` varchar(15) NOT NULL,
  `TanggalBeli` varchar(15) NOT NULL,
  `NamaPesanan` varchar(30) NOT NULL,
  `JenisOrder` varchar(15) NOT NULL,
  `Banyak` varchar(5) NOT NULL,
  `Satuan` varchar(5) NOT NULL,
  `HargaBeliS` double NOT NULL,
  `HargaJualS` double NOT NULL,
  `HargaJual` double NOT NULL,
  `HargaBeli` double NOT NULL,
  `NamaOutlet` varchar(20) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Keuntungan` varchar(20) NOT NULL,
  `Keterangan` varchar(20) NOT NULL,
  `Refund` varchar(5) NOT NULL,
  PRIMARY KEY (`NoTransaksi`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `order`
--

INSERT INTO `order` (`NoTransaksi`, `TanggalPesanan`, `TanggalBeli`, `NamaPesanan`, `JenisOrder`, `Banyak`, `Satuan`, `HargaBeliS`, `HargaJualS`, `HargaJual`, `HargaBeli`, `NamaOutlet`, `Alamat`, `Keuntungan`, `Keterangan`, `Refund`) VALUES
('100890MEK1780', '04/01/2019', '09/01/2019', 'Terong', 'Vegetables', '6', 'kg', 8000, 15000, 90000, 48000, 'Mekar Sari Comp', 'Jln. Simatupang  NO88 Tangerang Selatan', '42000', 'Sale', '0'),
('100300MEK600', '04/01/2019', '09/01/2019', 'Cabe Merah Besar', 'Vegetables', '10', 'kg', 15000, 30000, 255000, 150000, 'Mekar Sari Comp', 'Jln. Simatupang  NO88 Tangerang Selatan', '105000', 'Refund', '1,5'),
('100862MEK1724', '04/01/2019', '09/01/2019', 'Lidah Buaya', 'Fruit', '4', 'kg', 5000, 10000, 40000, 20000, 'Mekar Sari Comp', 'Jln. Simatupang  NO88 Tangerang Selatan', '20000', 'Sale', '0'),
('100213MEK426', '04/01/2019', '09/01/2019', 'Kacang Tanah', 'Others', '5', 'kg', 12000, 20000, 100000, 60000, 'Mekar Sari Comp', 'Jln. Simatupang  NO88 Tangerang Selatan', '40000', 'Sale', '0'),
('100384IWA768', '04/01/2019', '09/01/2019', 'Pisang Thai', 'Vegetables', '9', 'kg', 20000, 30000, 198000, 180000, 'Iwan Company', 'Jalan cawang jakarta timur', '18000', 'Refund', '2,4'),
('100496CIK992', '04/01/2019', '09/01/2019', 'Semangka', 'Fruit', '6', 'kg', 10000, 15000, 90000, 60000, 'CIkini Garden', 'Jln.Sukarno no 33 Rt 01/rw02, Jakarta Pusat', '30000', 'Sale', '0'),
('100820MEK1640', '04/01/2019', '09/01/2019', 'Bawang Merah', 'Vegetables', '4', 'kg', 15000, 25000, 100000, 60000, 'Mekar Sari Comp', 'Jln. Simatupang  NO88 Tangerang Selatan', '40000', 'Sale', '0'),
('100056ADI112', '04/01/2019', '09/01/2019', 'Cabe Rawit Hijau', 'Vegetables', '9', 'kg', 13000, 17000, 153000, 117000, 'Adipura Jaya Hotel', 'Jln. Simatupang by pass  no5 Jakarta Barat', '36000', 'Sale', '0'),
('100650ADI1300', '04/01/2019', '09/01/2019', 'Kentang', 'Vegetables', '5', 'kg', 15000, 25000, 125000, 75000, 'Adipura Jaya Hotel', 'Jln. Simatupang by pass  no5 Jakarta Barat', '50000', 'Sale', '2'),
('100312ADI624', '04/01/2019', '09/01/2019', 'Pisang Thai', 'Vegetables', '9', 'kg', 20000, 30000, 270000, 180000, 'Adipura Jaya Hotel', 'Jln. Simatupang by pass  no5 Jakarta Barat', '90000', 'Sale', '0');

-- --------------------------------------------------------

--
-- Struktur dari tabel `outlet`
--

CREATE TABLE IF NOT EXISTS `outlet` (
  `NO` varchar(20) NOT NULL,
  `TanggalBergabung` varchar(20) NOT NULL,
  `NamaOutlet` varchar(20) NOT NULL,
  `NamaPimpinan` varchar(20) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Telepon` varchar(15) NOT NULL,
  PRIMARY KEY (`NamaOutlet`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `outlet`
--

INSERT INTO `outlet` (`NO`, `TanggalBergabung`, `NamaOutlet`, `NamaPimpinan`, `Alamat`, `Telepon`) VALUES
('1', '12/02/2012', 'CIkini Garden', 'Budi Julian', 'Jln.Sukarno no 33 Rt 01/rw02, Jakarta Pusat', '092032323'),
('2', '04/12/2001', 'Merdeka Maju', 'ggg', 'Jln. Ahmad Supriadi no4 Jakarta Timur', '094543'),
('3', '11/05/2011', 'Bisnis Sentosa', 'julian', 'Jln. Simatupang by pass  no4 Jakarta Barat', '0934344'),
('4', '04/19/2011', 'Adipura Jaya Hotel', 'andre taulani sh', 'Jln. Simatupang by pass  no5 Jakarta Barat', '08234324'),
('5', '09/13/2018', 'Mekar Sari Comp', 'Antonio hermanwan', 'Jln. Simatupang  NO88 Tangerang Selatan', '08122343443'),
('6', '03/01/2012', 'Jaya Baya', 'Julian ', 'Jalan Margonda Depok', '089124324'),
('7', '09/15/2018', 'Garden 01', 'Intan Julian', 'Jalan Tanah Merdeka 6 Ciracas Jakarta Timur', '081233434'),
('8', '01/01/2019', 'Iwan Company', 'iwan', 'Jalan cawang jakarta timur', '0823546577'),
('9', '02/10/2012', 'sentosa', 'julian', 'Jalan Thamrin NO 44 ,jakarta pusat', '092032323');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

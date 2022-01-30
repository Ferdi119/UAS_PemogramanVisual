-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 27, 2022 at 01:53 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_penjualan`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `idadmin` varchar(6) NOT NULL,
  `namaadmin` varchar(50) NOT NULL,
  `passadmin` varchar(30) NOT NULL,
  `emailadmin` varchar(60) NOT NULL,
  `leveladmin` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`idadmin`, `namaadmin`, `passadmin`, `emailadmin`, `leveladmin`) VALUES
('adm001', 'admin', 'admin1', 'Adm107@gmail.com', 'ADMIN'),
('adm002', 'Ferdi maulana', 'Unsada', 'ferdi107@gmail.com', 'ADMIN'),
('adm006', 'Adrian Newey', 'Redbull', 'RedBull1@gmail.com', 'USER'),
('adm009', 'Maulana', 'maulana', 'Maul107@gmail.com', 'USER'),
('adm011', 'Wulandari', 'qwerty', 'Wlndri196@gmail.com', 'ADMIN'),
('adm012', 'Qwerty', 'qwerty', 'Querty01@Gmail.com', 'ADMIN'),
('adm013', 'Mohan', 'mohan', 'mhn0195@gmail.com', 'USER');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `idbarang` varchar(7) NOT NULL,
  `namabarang` varchar(50) NOT NULL,
  `hargabarang` int(11) NOT NULL,
  `jumlahbarang` int(11) NOT NULL,
  `satuanbarang` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_barang`
--

INSERT INTO `tbl_barang` (`idbarang`, `namabarang`, `hargabarang`, `jumlahbarang`, `satuanbarang`) VALUES
('BRG-001', 'Company Of Valor', 100000, 15, 'Steam keys'),
('BRG-002', 'Girl Frontline', 50000, 18, 'Steam keys'),
('BRG-003', 'Alan Wake', 120000, 15, 'Steam keys'),
('BRG-004', 'Genshin Impact', 100000, 25, 'EGS keys'),
('BRG-005', 'Medal of Duty', 95000, 20, 'Steam keys'),
('BRG-006', 'Call of Duty 1', 90000, 12, 'EGS keys'),
('BRG-008', 'Left 4 Dead 2', 70000, 8, 'Steam keys'),
('BRG-009', 'Portal Series', 150000, 20, 'Steam keys'),
('BRG-011', 'This is the police 2', 100000, 20, 'Steam keys'),
('BRG-013', 'The Division 2', 200000, 16, 'EGS keys'),
('BRG-014', 'Alexsander 20BC', 70000, 24, 'Steam keys'),
('BRG-015', 'Rebel cops', 120000, 24, 'EGS keys');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_detail1`
--

CREATE TABLE `tbl_detail1` (
  `no_transaksi` varchar(11) NOT NULL,
  `idbarang` varchar(7) NOT NULL,
  `namabarang` varchar(50) NOT NULL,
  `harga` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_detail1`
--

INSERT INTO `tbl_detail1` (`no_transaksi`, `idbarang`, `namabarang`, `harga`, `jumlah`, `subtotal`) VALUES
('T220121002', 'BRG-004', 'Genshin Impact', 100000, 2, 200000),
('T220121002', 'BRG-005', 'Medal of Duty', 95000, 3, 285000),
('T220121003', 'BRG-004', 'Genshin Impact', 100000, 2, 200000),
('T220121003', 'BRG-005', 'Genshin Impact', 100000, 1, 100000),
('T220121004', 'BRG-005', 'Medal of Duty', 95000, 5, 475000),
('T220121004', 'BRG-006', 'Call of Duty 1', 90000, 3, 270000),
('T220122005', 'BRG-004', 'Genshin Impact', 100000, 3, 300000),
('T220122005', 'BRG-008', 'Left 4 Dead 2', 70000, 5, 350000),
('T220122005', 'BRG-009', 'Portal Series', 150000, 10, 1500000),
('T220123006', 'BRG-001', 'Company Of Valor', 100000, 3, 300000),
('T220123006', 'BRG-003', 'Alan Wake', 120000, 9, 1080000),
('T220124007', 'BRG-008', 'Left 4 Dead 2', 70000, 2, 140000),
('T220124007', 'BRG-003', 'Alan Wake', 120000, 10, 1200000),
('T220124008', 'BRG-001', 'Company Of Valor', 100000, 2, 200000),
('T220124008', 'BRG-002', 'Girl Frontline', 50000, 2, 100000),
('T220125009', 'BRG-001', 'Company Of Valor', 100000, 3, 300000),
('T220125009', 'BRG-008', 'Left 4 Dead 2', 70000, 5, 350000),
('T220125010', 'BRG-003', 'Alan Wake', 120000, 4, 480000),
('T220125010', 'BRG-005', 'Medal of Duty', 95000, 14, 1330000),
('T220126011', 'BRG-008', 'Left 4 Dead 2', 70000, 12, 840000),
('T220126011', 'BRG-013', 'The Division 2', 200000, 3, 600000),
('T220126012', 'BRG-002', 'Girl Frontline', 50000, 3, 150000),
('T220126012', 'BRG-005', 'Medal of Duty', 95000, 4, 380000),
('T220126013', 'BRG-011', 'This is the police 2', 100000, 10, 1000000),
('T220126013', 'BRG-015', 'Rebel cops', 120000, 7, 840000),
('T220126013', 'BRG-001', 'Company Of Valor', 100000, 2, 200000);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `id_pelanggan` varchar(6) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `telp` varchar(20) NOT NULL,
  `Email` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`id_pelanggan`, `nama`, `alamat`, `telp`, `Email`) VALUES
('PL001', 'Waluyo', 'Jl. Radjiman Widyodiningrat', '08127592851', 'waluyo001@gmail.com'),
('PL002', 'Muhammad amirul', 'Jl. cakung No 4', '08572957328', 'Amirl011@gmail.com'),
('PL003', 'Ahmad Maulana', 'Jl. Ksatria No.10', '084926578931', 'Maul119@gmail.com'),
('PL007', 'Bill Gates', 'J. Silicon Valley No.3', '075439123593', 'Microsoft@gmail.com'),
('PL009', 'Maulana Hasan', 'Jl. Raya Inpres No.90', '085923481754', 'Hasan119@gmail.com'),
('PL010', 'Siregaer', 'Jl. Tipar cakung NO.12', '081395672845', 'Sireg104@gmail.com'),
('PL011', 'Muhammad Yamin', 'Jl. Medan Satria NO.12', '081934573829', 'Yamin8@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaksi`
--

CREATE TABLE `tbl_transaksi` (
  `no_transaksi` varchar(11) NOT NULL,
  `tanggal` date NOT NULL,
  `jam` time NOT NULL,
  `item` int(11) NOT NULL,
  `total` int(11) NOT NULL,
  `bayar` int(11) NOT NULL,
  `kembalian` int(11) NOT NULL,
  `id_pelanggan` varchar(6) NOT NULL,
  `idadmin` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_transaksi`
--

INSERT INTO `tbl_transaksi` (`no_transaksi`, `tanggal`, `jam`, `item`, `total`, `bayar`, `kembalian`, `id_pelanggan`, `idadmin`) VALUES
('T220121001', '2022-01-21', '20:45:13', 7, 590000, 600000, 10000, 'PL003', 'adm001'),
('T220121002', '2022-01-21', '20:53:55', 5, 485000, 500000, 15000, 'PL002', 'adm001'),
('T220121003', '2022-01-21', '20:55:06', 3, 300000, 300000, 0, 'PL001', 'adm001'),
('T220121004', '2022-01-21', '20:56:19', 8, 745000, 800000, 55000, 'PL001', 'adm001'),
('T220122005', '2022-01-23', '00:00:35', 18, 2150000, 2200000, 50000, 'PL003', 'adm008'),
('T220123006', '2022-01-23', '12:09:50', 12, 1380000, 1400000, 20000, 'PL001', 'adm008'),
('T220124007', '2022-01-24', '21:05:48', 12, 0, 135000, 135000, 'PL002', 'adm001'),
('T220124008', '2022-01-24', '21:11:12', 4, 300000, 400000, 100000, 'PL001', 'adm001'),
('T220125009', '2022-01-25', '23:43:18', 8, 650000, 650000, 0, 'PL008', 'adm001'),
('T220125010', '2022-01-25', '23:45:02', 18, 1810000, 2000000, 190000, 'PL006', 'adm001'),
('T220126011', '2022-01-26', '00:08:33', 15, 1440000, 1500000, 60000, 'PL009', 'adm001'),
('T220126012', '2022-01-26', '00:09:42', 7, 530000, 600000, 70000, 'PL003', 'adm001'),
('T220126013', '2022-01-26', '21:24:33', 19, 2040000, 2100000, 60000, 'PL011', 'adm006');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`idadmin`);

--
-- Indexes for table `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`idbarang`);

--
-- Indexes for table `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`id_pelanggan`);

--
-- Indexes for table `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  ADD PRIMARY KEY (`no_transaksi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

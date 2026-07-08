-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 01, 2026 at 09:05 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_kavling`
--

-- --------------------------------------------------------

--
-- Table structure for table `kavling`
--

CREATE TABLE `kavling` (
  `id_kavling` varchar(10) NOT NULL,
  `nama_kavling` varchar(100) NOT NULL,
  `bentuk` varchar(50) NOT NULL,
  `panjang` double NOT NULL,
  `lebar` double NOT NULL,
  `luas` double NOT NULL,
  `harga` decimal(15,2) NOT NULL,
  `status_kavling` enum('Tersedia','Terjual') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kavling`
--

INSERT INTO `kavling` (`id_kavling`, `nama_kavling`, `bentuk`, `panjang`, `lebar`, `luas`, `harga`, `status_kavling`) VALUES
('K001', 'Kavling A', 'Persegi Panjang', 20, 10, 200, 150000000.00, 'Tersedia'),
('K002', 'Kavling B', 'Persegi Panjang', 15, 12, 180, 130000000.00, 'Terjual'),
('K003', 'Kavling C', 'Persegi Panjang', 25, 10, 250, 200000000.00, 'Tersedia'),
('K004', 'Dhani', 'Persegi', 24, 67, 1608, 50000000.00, 'Terjual'),
('K005', 'Kavling Mawar C1', 'Persegi Panjang', 10, 20, 200, 160000000.00, 'Tersedia'),
('K006', 'Kavling Mawar C2', 'Persegi Panjang', 12, 20, 240, 190000000.00, 'Terjual'),
('K007', 'Kavling Sakura D1', 'Persegi', 14, 14, 196, 175000000.00, 'Tersedia'),
('K008', 'Kavling Sakura D2', 'Persegi', 16, 16, 256, 220000000.00, 'Terjual'),
('K009', 'Kavling Tulip E1', 'Persegi Panjang', 10, 25, 250, 210000000.00, 'Tersedia'),
('K010', 'Kavling Tulip E2', 'Persegi Panjang', 12, 25, 300, 250000000.00, 'Terjual'),
('K011', 'Kavling Kenanga F1', 'Persegi', 18, 18, 324, 275000000.00, 'Tersedia'),
('K012', 'Kavling Kenanga F2', 'Persegi', 20, 20, 400, 320000000.00, 'Terjual'),
('K013', 'Kavling Flamboyan G1', 'Persegi Panjang', 15, 25, 375, 300000000.00, 'Tersedia'),
('K014', 'Kavling Flamboyan G2', 'Persegi Panjang', 20, 25, 500, 400000000.00, 'Terjual'),
('K015', 'Kavling Bougenville H1', 'Persegi', 25, 25, 625, 500000000.00, 'Tersedia'),
('K016', 'Kavling Premium P1', 'Persegi Panjang', 30, 30, 900, 750000000.00, 'Tersedia'),
('K017', 'Kavling Premium P2', 'Persegi Panjang', 35, 35, 1225, 950000000.00, 'Terjual'),
('K018', 'Kavling Elite E1', 'Persegi', 40, 40, 1600, 1200000000.00, 'Tersedia'),
('K019', 'FARHAN', 'Persegi', 12, 40, 480, 12000000.00, 'Tersedia');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kavling`
--
ALTER TABLE `kavling`
  ADD PRIMARY KEY (`id_kavling`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

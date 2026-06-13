-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 06, 2026 at 01:25 AM
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
('K003', 'Kavling C', 'Persegi Panjang', 25, 10, 250, 200000000.00, 'Tersedia');

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

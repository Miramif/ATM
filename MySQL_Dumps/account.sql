-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Час створення: Жов 27 2019 р., 15:28
-- Версія сервера: 10.4.8-MariaDB
-- Версія PHP: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База даних: `atm`
--

-- --------------------------------------------------------

--
-- Структура таблиці `account`
--

CREATE TABLE `account` (
  `id` int(11) NOT NULL,
  `card_number` varchar(16) DEFAULT NULL,
  `bank_type` int(11) DEFAULT NULL,
  `card_status` varchar(3) DEFAULT NULL,
  `pin` varchar(4) DEFAULT NULL,
  `owner_name` varchar(50) DEFAULT NULL,
  `tel_number` varchar(13) DEFAULT NULL,
  `balance` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп даних таблиці `account`
--

INSERT INTO `account` (`id`, `card_number`, `bank_type`, `card_status`, `pin`, `owner_name`, `tel_number`, `balance`) VALUES
(1, '1414291930364576', 1, 'ACT', '4141', 'Korsun Alex Alex', '+386608211809', '361.95'),
(2, '1414904525941956', 1, 'ACT', '6565', 'Bogun John Johnson', '+385909423652', '3500.00'),
(3, '5166994506533844', 2, 'EXP', '3212', 'Vorsa Vas Dilov', '+384554720452', '4545.11'),
(4, '5166319346817723', 2, 'ACT', '6661', 'Tokar Drake Kirov', '+380097964156', '34250.10'),
(5, '3388706353608498', 3, 'BLK', '8981', 'Bagos Kert Torn', '+382242002148', '9995.10'),
(6, '3388837600425499', 3, 'BLK', '0981', 'Sumov Orkca Deln', '+389427712128', '24.23'),
(7, '2321355587515319', 4, 'ACT', '0031', 'Alonov Sanga Stoln', '+382391366805', '16999.11'),
(8, '2321361918276911', 4, 'ACT', '9811', 'Dolgenko Digas Polis', '+389892992530', '23444.65'),
(9, '1414201697552660', 1, 'ACT', '4141', 'Bogrev Soker Docker', '+389647116236', '25000.95'),
(10, '1414628912189916', 1, 'ACT', '8765', 'Kaver Anton Ant', '+386178106130', '100.00');

--
-- Індекси збережених таблиць
--

--
-- Індекси таблиці `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `card_number` (`card_number`),
  ADD KEY `bank_type` (`bank_type`);

--
-- AUTO_INCREMENT для збережених таблиць
--

--
-- AUTO_INCREMENT для таблиці `account`
--
ALTER TABLE `account`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Обмеження зовнішнього ключа збережених таблиць
--

--
-- Обмеження зовнішнього ключа таблиці `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `account_ibfk_1` FOREIGN KEY (`bank_type`) REFERENCES `banks` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

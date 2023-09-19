-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 19, 2023 at 05:15 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hoteldb`
--

-- --------------------------------------------------------

--
-- Table structure for table `checkin`
--

CREATE TABLE `checkin` (
  `ChckID` int(10) UNSIGNED NOT NULL,
  `GuestID` int(11) DEFAULT NULL,
  `RoomID` int(11) DEFAULT NULL,
  `CIDate` varchar(255) DEFAULT NULL,
  `CODate` varchar(255) DEFAULT NULL,
  `ChckStatusID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `checkin`:
--   `GuestID`
--       `guests` -> `GuestID`
--   `RoomID`
--       `rooms` -> `RoomID`
--   `ChckStatusID`
--       `checkin_status` -> `ChckStatusID`
--

--
-- Dumping data for table `checkin`
--

INSERT INTO `checkin` (`ChckID`, `GuestID`, `RoomID`, `CIDate`, `CODate`, `ChckStatusID`) VALUES
(1, 1, 1, '09/18/2023 - 02:29:05 am', '09/18/2023 -2:29:05 am', 2),
(2, 2, 4, '09/18/2023 - 05:34:30 pm', '09/18/2023 -5:34:30 pm', 2);

-- --------------------------------------------------------

--
-- Table structure for table `checkin_payment`
--

CREATE TABLE `checkin_payment` (
  `ChckPID` int(10) UNSIGNED NOT NULL,
  `ChckID` int(11) DEFAULT NULL,
  `EmployeeID` int(11) DEFAULT NULL,
  `GuestID` int(11) DEFAULT NULL,
  `RoomID` int(11) DEFAULT NULL,
  `PAmount` varchar(255) DEFAULT NULL,
  `PDate` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `checkin_payment`:
--

-- --------------------------------------------------------

--
-- Table structure for table `checkin_status`
--

CREATE TABLE `checkin_status` (
  `ChckStatusID` int(11) NOT NULL,
  `ChckStatus` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `checkin_status`:
--

--
-- Dumping data for table `checkin_status`
--

INSERT INTO `checkin_status` (`ChckStatusID`, `ChckStatus`) VALUES
(1, 'Checked-In'),
(2, 'Checked-Out');

-- --------------------------------------------------------

--
-- Table structure for table `checkout`
--

CREATE TABLE `checkout` (
  `ChckID` int(11) NOT NULL,
  `GuestID` int(11) DEFAULT NULL,
  `RoomID` int(11) DEFAULT NULL,
  `CIDate` varchar(255) DEFAULT NULL,
  `CODate` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `checkout`:
--

-- --------------------------------------------------------

--
-- Table structure for table `emp_details`
--

CREATE TABLE `emp_details` (
  `EmpID` int(11) NOT NULL,
  `EmpName` varchar(255) DEFAULT NULL,
  `EmpAge` varchar(255) DEFAULT NULL,
  `EmpTypeID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `emp_details`:
--   `EmpTypeID`
--       `emp_type` -> `EmpTypeID`
--

--
-- Dumping data for table `emp_details`
--

INSERT INTO `emp_details` (`EmpID`, `EmpName`, `EmpAge`, `EmpTypeID`) VALUES
(1, 'Manager', '32', 1),
(2, 'Attendant1', '24', 2),
(3, 'Attendant2', '29', 2);

-- --------------------------------------------------------

--
-- Table structure for table `emp_login`
--

CREATE TABLE `emp_login` (
  `EmpUserID` int(11) NOT NULL,
  `EmpUser` varchar(255) DEFAULT NULL,
  `EmpPass` varchar(255) DEFAULT NULL,
  `EmpID` int(11) NOT NULL,
  `EmpTypeID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `emp_login`:
--   `EmpID`
--       `emp_details` -> `EmpID`
--   `EmpTypeID`
--       `emp_type` -> `EmpTypeID`
--

--
-- Dumping data for table `emp_login`
--

INSERT INTO `emp_login` (`EmpUserID`, `EmpUser`, `EmpPass`, `EmpID`, `EmpTypeID`) VALUES
(1, 'man1', '12345', 1, 1),
(2, 'emp1', '12345', 2, 2),
(3, 'emp2', '12345', 3, 2);

-- --------------------------------------------------------

--
-- Table structure for table `emp_type`
--

CREATE TABLE `emp_type` (
  `EmpTypeID` int(11) NOT NULL,
  `EmpType` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `emp_type`:
--

--
-- Dumping data for table `emp_type`
--

INSERT INTO `emp_type` (`EmpTypeID`, `EmpType`) VALUES
(1, 'F&B Manager'),
(2, 'Front Desk Attendant');

-- --------------------------------------------------------

--
-- Table structure for table `guests`
--

CREATE TABLE `guests` (
  `GuestID` int(11) NOT NULL,
  `GName` varchar(255) DEFAULT NULL,
  `GAddress` varchar(255) DEFAULT NULL,
  `GNum` varchar(255) DEFAULT NULL,
  `CStatusID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `guests`:
--   `CStatusID`
--       `guest_status` -> `CustomerStatusID`
--

--
-- Dumping data for table `guests`
--

INSERT INTO `guests` (`GuestID`, `GName`, `GAddress`, `GNum`, `CStatusID`) VALUES
(1, 'Jhoey Dumaguit', 'Davao City', '09232808941', 3),
(2, 'Jules Alinsag', 'Davao City', '12345678901', 3);

-- --------------------------------------------------------

--
-- Stand-in structure for view `guest_avail`
-- (See below for the actual view)
--
CREATE TABLE `guest_avail` (
`ID` int(11)
,`Guest Name` varchar(255)
,`Address` varchar(255)
,`Contact No.` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `guest_checkedin`
-- (See below for the actual view)
--
CREATE TABLE `guest_checkedin` (
`Room No.` int(11)
,`ID` int(11)
,`Guest Name` varchar(255)
,`Check-In Date` varchar(255)
,`Check-Out Date` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `guest_info`
-- (See below for the actual view)
--
CREATE TABLE `guest_info` (
`ID` int(11)
,`Guest Name` varchar(255)
,`Address` varchar(255)
,`Contact No.` varchar(255)
,`Customer Status` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `guest_reservation`
-- (See below for the actual view)
--
CREATE TABLE `guest_reservation` (
`Room No.` int(11)
,`ID` int(11)
,`Guest Name` varchar(255)
,`Check-In Date` varchar(255)
,`Check-Out Date` varchar(255)
);

-- --------------------------------------------------------

--
-- Table structure for table `guest_status`
--

CREATE TABLE `guest_status` (
  `CustomerStatusID` int(11) NOT NULL,
  `CustomerStatus` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `guest_status`:
--

--
-- Dumping data for table `guest_status`
--

INSERT INTO `guest_status` (`CustomerStatusID`, `CustomerStatus`) VALUES
(1, 'Checked-In'),
(2, 'Has Reservation'),
(3, 'Checked-Out/No Reservation');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `ReservationID` int(11) NOT NULL,
  `GuestID` int(11) DEFAULT NULL,
  `RoomID` int(11) DEFAULT NULL,
  `CIDate` varchar(255) DEFAULT NULL,
  `CODate` varchar(255) DEFAULT NULL,
  `RStatusID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `reservation`:
--   `GuestID`
--       `guests` -> `GuestID`
--   `RoomID`
--       `rooms` -> `RoomID`
--   `RStatusID`
--       `reservation_status` -> `RStatusID`
--

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`ReservationID`, `GuestID`, `RoomID`, `CIDate`, `CODate`, `RStatusID`) VALUES
(1, 1, 1, '09/18/2023 -2:22:39 am', '09/18/2023 -2:22:39 am', 2);

-- --------------------------------------------------------

--
-- Table structure for table `reservation_payment`
--

CREATE TABLE `reservation_payment` (
  `ReservePID` int(10) UNSIGNED NOT NULL,
  `ReservationID` int(11) DEFAULT NULL,
  `EmployeeID` int(11) DEFAULT NULL,
  `GuestID` int(11) DEFAULT NULL,
  `RoomID` int(11) DEFAULT NULL,
  `PAmount` varchar(255) DEFAULT NULL,
  `PDate` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `reservation_payment`:
--

-- --------------------------------------------------------

--
-- Table structure for table `reservation_status`
--

CREATE TABLE `reservation_status` (
  `RStatusID` int(11) NOT NULL,
  `ReservationStatus` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `reservation_status`:
--

--
-- Dumping data for table `reservation_status`
--

INSERT INTO `reservation_status` (`RStatusID`, `ReservationStatus`) VALUES
(1, 'Reserved'),
(2, 'Checked-In');

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `RoomID` int(11) NOT NULL,
  `BedNum` int(11) DEFAULT NULL,
  `RoomTypeID` int(11) NOT NULL,
  `RoomStatusID` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `rooms`:
--   `RoomStatusID`
--       `room_status` -> `RoomStatusID`
--   `RoomTypeID`
--       `room_type` -> `RoomTypeID`
--

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`RoomID`, `BedNum`, `RoomTypeID`, `RoomStatusID`) VALUES
(1, 1, 1, 1),
(2, 1, 1, 1),
(3, 1, 1, 1),
(4, 1, 1, 1),
(5, 1, 1, 1),
(6, 1, 1, 1),
(7, 1, 1, 1),
(8, 1, 1, 1),
(9, 2, 2, 1),
(10, 2, 2, 1),
(11, 2, 2, 1),
(12, 2, 2, 1),
(13, 2, 2, 1),
(14, 2, 2, 1),
(15, 2, 2, 1),
(16, 2, 2, 1),
(17, 2, 2, 1),
(18, 2, 2, 1),
(19, 2, 2, 1),
(20, 2, 2, 1),
(21, 2, 2, 1),
(22, 2, 2, 1),
(23, 2, 2, 1),
(24, 2, 2, 1),
(25, 2, 2, 1),
(26, 2, 2, 1),
(27, 2, 2, 1),
(28, 2, 2, 1),
(29, 2, 2, 1),
(30, 2, 2, 1),
(31, 1, 3, 1),
(32, 1, 3, 1),
(33, 1, 3, 1),
(34, 1, 3, 1),
(35, 1, 3, 1),
(36, 1, 3, 1),
(37, 1, 3, 1),
(38, 1, 3, 1),
(39, 1, 3, 1);

-- --------------------------------------------------------

--
-- Stand-in structure for view `rooms_available`
-- (See below for the actual view)
--
CREATE TABLE `rooms_available` (
`Room No.` int(11)
,`No. Of Beds` int(11)
,`Room Type` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `rooms_occupied`
-- (See below for the actual view)
--
CREATE TABLE `rooms_occupied` (
`Room No.` int(11)
,`No. Of Beds` int(11)
,`Room Type` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `rooms_reserved`
-- (See below for the actual view)
--
CREATE TABLE `rooms_reserved` (
`Room No.` int(11)
,`No. Of Beds` int(11)
,`Room Type` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `room_info`
-- (See below for the actual view)
--
CREATE TABLE `room_info` (
`Room No.` int(11)
,`No. Of Beds` int(11)
,`Room Type` varchar(255)
,`Room Price` decimal(10,2)
,`Room Status` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `room_profile`
-- (See below for the actual view)
--
CREATE TABLE `room_profile` (
`Room No.` int(11)
,`Room Type` varchar(255)
,`No. Of Beds` int(11)
,`Room Status` varchar(255)
);

-- --------------------------------------------------------

--
-- Table structure for table `room_status`
--

CREATE TABLE `room_status` (
  `RoomStatusID` int(11) NOT NULL,
  `RoomStatus` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `room_status`:
--

--
-- Dumping data for table `room_status`
--

INSERT INTO `room_status` (`RoomStatusID`, `RoomStatus`) VALUES
(1, 'Available'),
(2, 'Reserved'),
(3, 'Occupied'),
(4, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `room_type`
--

CREATE TABLE `room_type` (
  `RoomTypeID` int(11) NOT NULL,
  `RoomType` varchar(255) DEFAULT NULL,
  `RoomPrice` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `room_type`:
--

--
-- Dumping data for table `room_type`
--

INSERT INTO `room_type` (`RoomTypeID`, `RoomType`, `RoomPrice`) VALUES
(1, 'Single', 750.00),
(2, 'Double', 850.00),
(3, 'Matrimonial', 850.00),
(4, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure for view `guest_avail`
--
DROP TABLE IF EXISTS `guest_avail`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `guest_avail`  AS SELECT `guests`.`GuestID` AS `ID`, `guests`.`GName` AS `Guest Name`, `guests`.`GAddress` AS `Address`, `guests`.`GNum` AS `Contact No.` FROM `guests` WHERE `guests`.`CStatusID` = 3 ;

-- --------------------------------------------------------

--
-- Structure for view `guest_checkedin`
--
DROP TABLE IF EXISTS `guest_checkedin`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `guest_checkedin`  AS SELECT `checkin`.`RoomID` AS `Room No.`, `guests`.`GuestID` AS `ID`, `guests`.`GName` AS `Guest Name`, `checkin`.`CIDate` AS `Check-In Date`, `checkin`.`CODate` AS `Check-Out Date` FROM (`guests` join `checkin` on(`guests`.`GuestID` = `checkin`.`GuestID`)) WHERE `checkin`.`ChckStatusID` = 1 ;

-- --------------------------------------------------------

--
-- Structure for view `guest_info`
--
DROP TABLE IF EXISTS `guest_info`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `guest_info`  AS SELECT `guests`.`GuestID` AS `ID`, `guests`.`GName` AS `Guest Name`, `guests`.`GAddress` AS `Address`, `guests`.`GNum` AS `Contact No.`, `guest_status`.`CustomerStatus` AS `Customer Status` FROM (`guests` join `guest_status` on(`guests`.`CStatusID` = `guest_status`.`CustomerStatusID`)) ;

-- --------------------------------------------------------

--
-- Structure for view `guest_reservation`
--
DROP TABLE IF EXISTS `guest_reservation`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `guest_reservation`  AS SELECT `reservation`.`RoomID` AS `Room No.`, `guests`.`GuestID` AS `ID`, `guests`.`GName` AS `Guest Name`, `reservation`.`CIDate` AS `Check-In Date`, `reservation`.`CODate` AS `Check-Out Date` FROM (`reservation` join `guests` on(`reservation`.`GuestID` = `guests`.`GuestID`)) WHERE `reservation`.`RStatusID` = 1 ;

-- --------------------------------------------------------

--
-- Structure for view `rooms_available`
--
DROP TABLE IF EXISTS `rooms_available`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `rooms_available`  AS SELECT `rooms`.`RoomID` AS `Room No.`, `rooms`.`BedNum` AS `No. Of Beds`, `room_type`.`RoomType` AS `Room Type` FROM (`rooms` join `room_type` on(`rooms`.`RoomTypeID` = `room_type`.`RoomTypeID`)) WHERE `rooms`.`RoomStatusID` = 1 ;

-- --------------------------------------------------------

--
-- Structure for view `rooms_occupied`
--
DROP TABLE IF EXISTS `rooms_occupied`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `rooms_occupied`  AS SELECT `rooms`.`RoomID` AS `Room No.`, `rooms`.`BedNum` AS `No. Of Beds`, `room_type`.`RoomType` AS `Room Type` FROM (`rooms` join `room_type` on(`room_type`.`RoomTypeID` = `rooms`.`RoomTypeID`)) WHERE `rooms`.`RoomStatusID` = 3 ;

-- --------------------------------------------------------

--
-- Structure for view `rooms_reserved`
--
DROP TABLE IF EXISTS `rooms_reserved`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `rooms_reserved`  AS SELECT `rooms`.`RoomID` AS `Room No.`, `rooms`.`BedNum` AS `No. Of Beds`, `room_type`.`RoomType` AS `Room Type` FROM (`rooms` join `room_type` on(`room_type`.`RoomTypeID` = `rooms`.`RoomTypeID`)) WHERE `rooms`.`RoomStatusID` = 2 ;

-- --------------------------------------------------------

--
-- Structure for view `room_info`
--
DROP TABLE IF EXISTS `room_info`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `room_info`  AS SELECT `rooms`.`RoomID` AS `Room No.`, `rooms`.`BedNum` AS `No. Of Beds`, `room_type`.`RoomType` AS `Room Type`, `room_type`.`RoomPrice` AS `Room Price`, `room_status`.`RoomStatus` AS `Room Status` FROM ((`room_status` join `rooms` on(`room_status`.`RoomStatusID` = `rooms`.`RoomStatusID`)) join `room_type` on(`rooms`.`RoomTypeID` = `room_type`.`RoomTypeID`)) ;

-- --------------------------------------------------------

--
-- Structure for view `room_profile`
--
DROP TABLE IF EXISTS `room_profile`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `room_profile`  AS SELECT `rooms`.`RoomID` AS `Room No.`, `room_type`.`RoomType` AS `Room Type`, `rooms`.`BedNum` AS `No. Of Beds`, `room_status`.`RoomStatus` AS `Room Status` FROM ((`rooms` join `room_status` on(`rooms`.`RoomStatusID` = `room_status`.`RoomStatusID`)) join `room_type` on(`rooms`.`RoomTypeID` = `room_type`.`RoomTypeID`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `checkin`
--
ALTER TABLE `checkin`
  ADD PRIMARY KEY (`ChckID`),
  ADD KEY `CRoomID` (`RoomID`),
  ADD KEY `CGuestID` (`GuestID`),
  ADD KEY `ChckStatusID` (`ChckStatusID`);

--
-- Indexes for table `checkin_payment`
--
ALTER TABLE `checkin_payment`
  ADD PRIMARY KEY (`ChckPID`);

--
-- Indexes for table `checkin_status`
--
ALTER TABLE `checkin_status`
  ADD PRIMARY KEY (`ChckStatusID`);

--
-- Indexes for table `emp_details`
--
ALTER TABLE `emp_details`
  ADD PRIMARY KEY (`EmpID`),
  ADD KEY `EmpTypeID` (`EmpTypeID`);

--
-- Indexes for table `emp_login`
--
ALTER TABLE `emp_login`
  ADD PRIMARY KEY (`EmpUserID`),
  ADD KEY `EmpID` (`EmpID`),
  ADD KEY `TypeID` (`EmpTypeID`);

--
-- Indexes for table `emp_type`
--
ALTER TABLE `emp_type`
  ADD PRIMARY KEY (`EmpTypeID`);

--
-- Indexes for table `guests`
--
ALTER TABLE `guests`
  ADD PRIMARY KEY (`GuestID`),
  ADD KEY `CStatus` (`CStatusID`);

--
-- Indexes for table `guest_status`
--
ALTER TABLE `guest_status`
  ADD PRIMARY KEY (`CustomerStatusID`);

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`ReservationID`),
  ADD KEY `RRoomID` (`RoomID`),
  ADD KEY `RGuestID` (`GuestID`),
  ADD KEY `RStatusID` (`RStatusID`);

--
-- Indexes for table `reservation_payment`
--
ALTER TABLE `reservation_payment`
  ADD PRIMARY KEY (`ReservePID`);

--
-- Indexes for table `reservation_status`
--
ALTER TABLE `reservation_status`
  ADD PRIMARY KEY (`RStatusID`);

--
-- Indexes for table `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`RoomID`),
  ADD KEY `RoomType` (`RoomTypeID`),
  ADD KEY `RoomStatus` (`RoomStatusID`);

--
-- Indexes for table `room_status`
--
ALTER TABLE `room_status`
  ADD PRIMARY KEY (`RoomStatusID`);

--
-- Indexes for table `room_type`
--
ALTER TABLE `room_type`
  ADD PRIMARY KEY (`RoomTypeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `checkin`
--
ALTER TABLE `checkin`
  MODIFY `ChckID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `checkin_payment`
--
ALTER TABLE `checkin_payment`
  MODIFY `ChckPID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `emp_details`
--
ALTER TABLE `emp_details`
  MODIFY `EmpID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `emp_login`
--
ALTER TABLE `emp_login`
  MODIFY `EmpUserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `guests`
--
ALTER TABLE `guests`
  MODIFY `GuestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `ReservationID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `reservation_payment`
--
ALTER TABLE `reservation_payment`
  MODIFY `ReservePID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `checkin`
--
ALTER TABLE `checkin`
  ADD CONSTRAINT `CGuestID` FOREIGN KEY (`GuestID`) REFERENCES `guests` (`GuestID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `CRoomID` FOREIGN KEY (`RoomID`) REFERENCES `rooms` (`RoomID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `ChckStatusID` FOREIGN KEY (`ChckStatusID`) REFERENCES `checkin_status` (`ChckStatusID`);

--
-- Constraints for table `emp_details`
--
ALTER TABLE `emp_details`
  ADD CONSTRAINT `EmpTypeID` FOREIGN KEY (`EmpTypeID`) REFERENCES `emp_type` (`EmpTypeID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `emp_login`
--
ALTER TABLE `emp_login`
  ADD CONSTRAINT `EmpID` FOREIGN KEY (`EmpID`) REFERENCES `emp_details` (`EmpID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `TypeID` FOREIGN KEY (`EmpTypeID`) REFERENCES `emp_type` (`EmpTypeID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `guests`
--
ALTER TABLE `guests`
  ADD CONSTRAINT `CStatus` FOREIGN KEY (`CStatusID`) REFERENCES `guest_status` (`CustomerStatusID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `RGuestID` FOREIGN KEY (`GuestID`) REFERENCES `guests` (`GuestID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `RRoomID` FOREIGN KEY (`RoomID`) REFERENCES `rooms` (`RoomID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `RStatusID` FOREIGN KEY (`RStatusID`) REFERENCES `reservation_status` (`RStatusID`);

--
-- Constraints for table `rooms`
--
ALTER TABLE `rooms`
  ADD CONSTRAINT `RoomStatus` FOREIGN KEY (`RoomStatusID`) REFERENCES `room_status` (`RoomStatusID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `RoomType` FOREIGN KEY (`RoomTypeID`) REFERENCES `room_type` (`RoomTypeID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

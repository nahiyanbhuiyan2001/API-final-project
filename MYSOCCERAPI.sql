CREATE DATABASE SoccerStats;
USE SoccerStats;

CREATE TABLE Teams(
	TeamNum INT NOT NULL UNIQUE,
    TableRank INT NOT NULL,
    LastYearPos Int NOT NULL,
    UCLQualify VARCHAR(16) NOT NULL,
    PRIMARY KEY (TeamNo)
);

CREATE TABLE Players(
	TeamNum INT NOT NULL UNIQUE,
	PlayerName VARCHAR(20) NOT NULL,
	Goals INT NOT NULL,
	Assists INT NOT NULL,
	Top10 VARCHAR(20),
	PRIMARY KEY (PlayerName),
	FOREIGN KEY (TeamNo) REFERENCES Teams(TeamNo)
);

INSERT INTO Teams (TeamNo, TablePos, LastYearPos, UCLQualify) VALUES 
	(1, 1, 1, "yes"),
	(2, 4, 2, "no");
    
INSERT INTO Players (TeamNo, PlayerName, Goals, Assists, Top10) VALUES
	(1, "Fati", 10, 2, "no"),
	(2, "Messi", 19, 1, "yes");

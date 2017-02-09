Feature: BookMaintenance
	In order to maintain books easily
	As a librarian
	I want to add, update, query books information

Scenario: Add a book
	Given go to Book Registering Page
	And a book for registering
	| ISBN          | Name  |
	| 9789869094481 | 玩出好創意 |	
	When Add book into library
	Then added successfully message should be displayed

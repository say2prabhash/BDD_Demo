Feature: Score
	In order to build a cricket game
	As a developer
	I want to calculate the batter's score
@mytag
Scenario: Batter gets out without scoring
	Given I started a game of cricket
	When Batter gets out
	Then Batter score should be 0

	@mytag
Scenario: Batter scores runs before getting out
	Given I started a game of cricket
	And Batter scores 4 runs
	When Batter gets out
	Then Batter score should be 4

 Scenario Outline: Batter scores multiple times before getting out 
 Given I started a game of cricket
	And Batter scores <ball1> runs
	And Batter scores <ball2> runs
	And Batter scores <ball3> runs
	When Batter gets out
	Then Batter score should be <total>
	And game should be finished
	Examples: 
	| ball1 | ball2 | ball3 | total |
	| 0     | 0     | 0     | 0     |
	| 1     | 2     | 3     | 6     |
	| 2     | 4     | 6     | 12    |

	Scenario: Batter cannot score runs after getting out
	Given I started a game of cricket
	And Batter scores 2 runs
	And Batter scores 5 runs
	And Batter gets out
	When Batter scores 4 runs
	Then Batter score should be 7

# _Queen Attack_

#### _This demonstrates beginner level C#._

#### By _**Matthew**_


## Description

_A page demonstrates basic C# with a console._
_Determine if a user inputted queen and piece position are such that the queen can attack_


| Spec                                                                                    | Input                       | Output |
|-----------------------------------------------------------------------------------------|-----------------------------|--------|
| create a queen object with a constructor that points to an x y position on the board    | new Queen(x,y)              |        |
| create a method on the queen that determines if a position can be taken by the queen    | --------------------------- | -----  |
| determine if a piece is in the same row as a queen. - check equality of y values        |                             |        |
| determine if a piece is in the same column as a queen - check equality of x values      |                             |        |
| determine if a piece is in a diagonal relation with the queen - iterate in 4 directions | --------------------------- | ------ |
| determine which direction is most logical to iterate-------                             | -----------------------     |        |
| if piece is to the right of the queen and above then iterate over that line             | +1 +1                       |        |
| if piece is to the right of the queen and below then iterate over that line             | +1 -1                       |        |
| if piece is the left and above the queen then iterate over that line                    | -1 +1                       |        |
| if piece is to the left and below the queen then iterate over that line                 | -1 -1                       |        |
| terminal the diagonal search if either value is -less than zero or greater than 7.      |                             |        |

## Setup/Installation Requirements


## Known Bugs

_I don't think there are any bugs but please tell me if you see any._

## Support and contact details

_Open a Github issue if you see a problem or have questions_

## Technologies Used

_This is a C# and console thing._

### License

*Feel free to use this code as you please*

Copyright (c) 2020 **_Matthew_**

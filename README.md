# ERC1155UnityConnector
Allows you to easily access ERC1155 (Rarible) token information from within Unity. One use case would be to check a wallet for a certain NFT, if it has at least one of the token you are looking for then perform an action.

Simply download and put these files in your Unity projects Asset folder. 

I have created a starter file as an example. Attach the ERC1155CheckForCoinAmounts script to an object with a collider and trigger, fill in the relevant public fields and then when an object with the tag "Player" enters the trigger it will Debug.log the amount of the coin that the persons wallet has. You can easily expand on this code to have it trigger some sort of action in your game.

Coming soon:

1. Ability to gather the metadata (image/description/etc..) of the ERC1155 coin and then you could also use that in interesting ways within the game world. 
2. Use of transaction signing to verify the wallet address entered by user. Perhaps if possible have user link their wallet with QR code, just have some way to verify the wallet the user entered is their own. This would stop people from entering someone elses wallet address in and "using" their tokens.





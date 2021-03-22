# ERC1155UnityConnector
Allows you to easily access ERC1155 (Rarible) token information from within Unity. One use case would be to check a wallet for a certain NFT, if it has at least one of the token you are looking for then perform an action.

Simply download and put these files in your Unity projects Asset folder. Attach the ERC1155CheckForCoinAmounts script to an object with a collider and trigger, fill in the relevant public fields and when an object with the tag "Player" enters the trigger it will Debug.log the amount of the coin that the persons wallet has. You could easily use the amount of coins to trigger/initiate others events in your Unity game world now. 

Coming soon:

1. Ability to gather the metadata (image/description/etc..) of the ERC1155 coin and then you could also use that in interesting ways within the game world. 
2. Use of transaction signing to verify the wallet address entered by user.





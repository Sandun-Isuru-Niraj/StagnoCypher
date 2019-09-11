# Steganographic Text Encryption Application

### Introduction to Steganography
The Starting of the Multimedia data in our electronic world, communicating the information without detecting the secret messages is concealed massively. In that case cryptography and Steganography is came to the ground for facing that types of problems in advance. Steganography is the art of hiding information in ways that prevent the detection of hid-den messages. Steganography, derived from Greek, literally means “covered writing.” It includes a vast array of secret communications methods that conceal the message’s very existence. These methods include invisible inks, microdots, character arrangement, digital signatures, covert channels, and spread spectrum communications. Steganography and cryptography are cousins in the spy craft family. Cryptography scrambles a message so it cannot be understood. Steganography hides the message so it cannot be seen. A message in ciphertext, for instance, might arouse suspicion on the part of the recipient while an “invisible” message created with steganographic methods will not.
In the Steganography, we are doing the embedding the information within the image, thus anyone cannot be understanding the hidden message at a glance. And anyone won’t be suspicious about general image without any connection to the secret message. There are many applications for techniques that embed information within digital images. The dispatch  of hidden messages is an obvious function, but today’s technology stimulates even more subtle uses. In-band captioning, such as movie subtitles, is one such use where textual information can be embedded  within the image. The ability to deposit  image creation and  revision information within the  image  provides a form of revision tracking as another possible application of digital steganography. This  avoids  the  need  for  maintaining two  separate  media,  one  containing  the  image  itself  and  one containing the revision data.

### Methodology
![Method that used to Steganography](https://i.ibb.co/pWN4949/f.png)
Steganography has a simple workflow to achieve. To a computer, an image is an array of numbers that represent light intensities at various points (pixels). These pixels make up the image’s raster data. A common image size is 640 ×480 pixels and 256 colours (or8 bits per pixel). Such an image could contain about300 kilobits of data. Digital images are typically stored in either 24-bitor 8-bit files. A 24-bit image provides the most space for hiding information;  however,  it can be quite large (except for JPEG images). All colour variations for the pixels are derived from three primary colours:  red,  green,  and  blue.  Each  primary colour is represented by 1 byte; 24-bit images use 3 bytes per pixel to represent a colour value. These 3 bytes can be represented as hexadecimal, decimal, and binary values. In many Web pages, the background colour is represented by a six-digit hexadecimal number, actually three pairs representing red, green, and blue. A white background would have the value FFFFFF: 100 percent red (FF), 100 percent green (FF), and 100 percent blue (FF). Its decimal value is 255, 255, 255, and its binary  value  is  11111111,  11111111,  11111111, which are the three bytes making up white. This definition of a white background is analogous to the colour definition of a single pixel in an image. Pixel representation contributes to file size. For example, suppose we have 24-bit image 1,024 pixels wide by 768 pixels high—a common resolution for high-resolution graphics. Such an image has more than two million pixels, each having such a definition, which would produce a file exceeding 2 Mbytes. Because such24-bit images are still relatively uncommon on the Internet,  their  size  would  attract  attention  during transmission. File compression would thus be beneficial, if not necessary, to transmit such a file.
For embedding the data to image file, we need both instances of data. First one is an image file that we going to image hide the message and second one is that data we are going to hide inside the image. When combined, the cover image  and  the  embedded  message  make  a  stego image. stego-key (a type of password) may also be used to hide, then later decode, the message. Most steganography software neither supports nor recommends using JPEG images but recommends instead the use of lossless 24-bit images such as BMP. The next-best alternative to 24-bit images is 256-coloror  grey-scale  images.  The  most  common  of  these found on the Internet are GIF files. In 8-bit colour images such as GIF files, each pixel is represented as a single byte, and each pixel merely points to a colour index table (a palette) with 256 possible colours. The pixel’s value, then, is between 0 and255. The software simply paints the indicated color on the screen at the selected pixel position. Figure 1a,a red palette, illustrates subtle changes in Colour variations: visually differentiating between many of three-color is difficult. Figure 1b shows subtle colour changes as well as those that seem drastic.
Information can be hidden many ways in images. To hide information, straight message insertion may encode every bit of information in the image or selectively embed the message in “noisy” areas that draw less attention those areas where there is a great deal of natural colour variation. The message may also be scattered randomly throughout the image. Redundant pattern encoding the cover image with the message.

Several ways exist to hide information in digital images. Common approaches include,

 - Least significant bit insertion
 - Masking and filtering
 - Algorithms and transformations
In this project we have used least significant bit insertion, 

Least significant bit (LSB) insertion is a common, simple  approach  to  embedding  information  in  a cover file. To hide an image in the LSBs of each byte of a 24-bit image, you can store 3 bits in each pixel. A 1,024 ×768 image has the potential to hide total of 2,359,296 bits (294,912 bytes) of information. For example, the letter A can be hidden in three pixels(assuming no compression). The original raster data for 3 pixels (9 bytes) may be,

			(00100111 11101001 11001000)
			(00100111 11001000 11101001)
			(11001000 00100111 11101001)
The binary value for A is 10000011. Inserting the binary value for A in the three pixels would result in,

			(00100111 11101000 11001000)
			(00100110 11001000 11101000)
			(11001000 00100111 11101001)
The underlined bits are the only three changed in the 8 bytes used. On average, LSB requires that only half the bits in an image be changed. You can hide data in the least and second least significant bits and still the human eye would not be able to discern it. 

### Algorithm
1.	Split  the  Cover  Image  C  into  three  channels  Red (R), Green (G), Blue (B).
2.	Convert   B,   and   G   into   blocks;   B=   {b1,b2,b3......bn},  G=  {g1,g2,g3......gn}  where  each  block is only one pixel.
3.	Convert  each  block  from  B,  and  G  to  its  ASCII format.
4.	Split M into characters, M= {m1 ,m2,m3........mn}.
5.	Take mi from  M and  Convert  it  into  Braille  6-bit representation by using LSBraille method [14].
6.	i =1                 // where i is B and G counter.                       
7.	Take bifrom B, and gifrom G.
8.	Take the last three bits from bi.
9.	Apply  the  equation  (2)  and  (3)  to  obtain  the  output N2, N3.
10.	If (mi(1)=N2 & mi(2)=N3) Then  
	b(i,6:8)=b(i,6:8)              
	g(i, end)=mi(3)
	i= i+1
Else If (mi(1) ! = N2 & mi(2) = N3) Then   
	b(i, 7:7)= NOT (b(I, 7:7))
	g(i, end)=mi(3)
	i= i+1
Else If(mi(1) = N2 & mi(2) != N3) Then   
	b(i, 6:6) = NOT(b(i, 6:6))
	g(i, end)=mi(3)      
	i= i+1
Else If(mi(1) ! = N2 & mi(2) ! = N3) Then 
	b(i, 8:8) = NOT (b(i, 8:8))	
g (i, end)=mi(3)   
	i=i+1
End if
End if 
End if
End if
11.	Repeat  steps  9,  and  10,    but  on  step  10  change  the message  bits mi by  the  last  three  bits  ;  m(4),  m(5), m(6)
12.	Repeat  steps  from  6  to  11  until  the  whole  M  has been embedded in C.
13.	Convert B, and G from binary to decimal.
14.	Merge the three channels R, G, B again to construct the stego Image.

### How it works.
##### To Encrypt a message

 - First Select Image from the Image selection area.
 
 ![](https://i.ibb.co/5Yx8SGW/1.png)
 
 - Then add your message at the “Message need to be encrypt” Text area.
 - You can add Encryption Password if you needed. (Optional)
 - Then click Encrypt button. This will encrypt your message inside the image.
 - Then in the File explorer window give a file name and location to save your encrypted image.

##### To Decrypt a message

 - First Select Image that has encrypted message from the Image selection area.

![](https://i.ibb.co/QjjBV0V/2.png)

 - Then type Password if you entered in the Encryption process. (If not keep it as blank)
 - Then click Decrypt Button.
 - This will show the message if the image has, If not it shows error message saying,

![](https://i.ibb.co/P6vGs8d/3.png)

### References

 - Johnson, Neil F., and Sushil Jajodia. "Exploring steganography: Seeing the unseen." Computer 31.2 (1998): 26-34.
 - Marvel, Lisa M., Charles G. Boncelet, and Charles T. Retter. "Spread spectrum image steganography." IEEE Transactions on image processing 8.8 (1999): 1075-1083.
 - Morkel, Tayana, Jan HP Eloff, and Martin S. Olivier. "An overview of image steganography." ISSA. 2005.
 - Marwa M. Emam, Abdelmgeid A. Aly, Fatma A. Omara “A Modified Image Steganography Method based on LSB Technique” - International Journal of Computer Applications (0975 –8887)


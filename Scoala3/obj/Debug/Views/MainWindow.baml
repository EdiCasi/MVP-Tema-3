   M S B A M L   `   `   `  ����B  >Scoala3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Scoala3.ViewsScoala3.Views  5   	   5clr-namespace:Scoala3.ViewModelScoala3.ViewModel  5	   	   5clr-namespace:Scoala3.ConverterScoala3.Converter  5
   	       Scoala3.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Scoala3.Views     5   	   /ctxclr-namespace:Scoala3.ViewModel     5	   	   3convertclr-namespace:Scoala3.Converter     5
   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
������� � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      %  Scoala3.ViewModel.LoginScreenVM  5   
   .��5      �  � 	Resources 5   
   &   Scoala3.Converter.AccountConvert   accountConvert��%   &	          5      6%   5      .+�5   
   �� -   5         ��Name$ 	ussername��5      $��Center=�5       �� TextWrapping$
 Wrap=�5      $	��Top=�5      $	��156��5      $��	0,143,0,0q�5      $��31��5       $��18(�5!      �� 5$   
   -   5        $ password��5$      $��Center=�5%      $	��Top=�5&      $	��156��5'      $��	0,194,0,0q�5(      $��31��5)      $��18(�5*      �� 5-   
   $��Login��5.      $��Center=�5/      $��0,51,0,0q�50      $	��Top=�51      $
��Bold"�52      $��30(�53      �� 56   
   $��	Username:��57      $
��Left=�58      $��217,140,0,0q�59      $	��Top=�5:      $
��Bold"�5;      $��18(�5<      �� 5?   
   $��	Password:��5@      $
��Left=�5A      $��217,191,0,0q�5B      $	��Top=�5C      $
��Bold"�5D      $��18(�5E      �� 5G   
   -   5         ��Name$ Login��5H      $��Login��5I      $��Center=�5J      $	��Top=�5K      $��	0,252,0,0q�5L      $��35��5M      $	��100��5N      $
��Bold"�5O      $��18(�5P        NewGameButtonStyle#��[ 5Q      ��5R      �� *LogInCommand+��5T      `� 5U       `� 	Converter# [  6   .1�5V      ��  �� ElementName$ 	ussername��6   	 �� Path$
	 Text�66   �� 5W      $ password��6   $
	 Text�65   5X      5Z      5[      5\      
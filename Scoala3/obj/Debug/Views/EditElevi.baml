   M S B A M L   `   `   `  ����B  >Scoala3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Scoala3.ViewsScoala3.Views  5   	   5clr-namespace:Scoala3.ViewModelScoala3.ViewModel  5   	   7 clr-namespace:Scoala3.ConvertersScoala3.Converters  5	   	       Scoala3.Views.EditElevi   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Scoala3.Views     5   	   /ctxclr-namespace:Scoala3.ViewModel     5   	   4convert clr-namespace:Scoala3.Converters     5	   	     � Title$  	EditElevi��5   	   $	��600��6   $	��500��6(   
������� � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      #  Scoala3.ViewModel.EditEleviVM  5   
   .��5      � .+�5   
   �� $
��Left=�6   $��Bottom=�60   .+�5      �� $
��Back��5      $	��100��5      $��30��5      $
��Bold"�5      $��18(�5         NewGameButtonStyle#��[  5      ��5      �� *GoBackCommand+5       �� 5!   
   $��Right=�6   $��Bottom=�61   .+�5"      �� $��Refresh��5#      $	��100��5$      $��30��5%      $
��Bold"�5&      $��18(�5'      #��[  5(      ��5)      �� *RefreshCommand+5+      �� 5,   
   $��Center=�6   $	��Top=�62   .+�5.      �� $��Selectati numele:��5/      $
��Bold"�50      $��18(�51      �� 54      -   5        $��nameTextBox��55      ��56      ��  �� ElementName$ elevGrid�� �� Path$ SelectedItem.Nume� �� UpdateSourceTrigger$ PropertyChanged=��� 5:      $��Id Elev:��5;      $
��Bold"�5<      $��18(�5=      �� 5@      -   5        $��idElevTextBlock��5A      
���������5B      �� $ elevGrid��$ SelectedItem.IdElev�$ PropertyChanged=�5D      �� 5G      $��	Id clasa:��5H      $
��Bold"�5I      $��18(�5J      �� 5M      -   5        $��idClasaTextBox��5N      
���������5O      �� $ 	calseGrid��$ SelectedItem.Id�$ PropertyChanged=�5Q      �� 5T      $��Selectati clasa:��5U      $
��Bold"�5V      $��18(�5W      &   System.Windows.Controls.DataGrid  5Z      -   5        $��	calseGrid��5Z         AutoGenerateColumns .     
IsReadOnly . $��Visible=�5\      $��90��5]      ��5[      �� *Clase+   Columns 5^      0  *System.Windows.Controls.DataGridTextColumn  5_      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id clasa��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *Id+  5`      $	 
Nume clasa��6)   
 6=   �� *	NumeClasa+  5a      $	 Specializare��6)   
 6?   �� *Specializare+  5b      $	 Nume diriginte��6)   
 6A   �� *NumeDiriginte+  5c      $	 AnStudii��6)   
 6;   �� *
AnStudii+5e      �� 5g      $��Selectati elevul:��5h      $
��Bold"�5i      $��18(�5j        5m      -   5        $��elevGrid��5m       .   . $��Visible=�5o      $��90��5p      ��5n      �� *Elevi+ 5q        5r      $	 ID��6)   
 65   �� *IdElev+  5s      $	 	Nume Elev��6)   
 6<   �� *Nume+  5t      $	 Specializare��6)   
 6?   �� *Specializare+  5u      $	 	An Studii��6)   
 6<   �� *
AnStudii+5w      �� 5y      $��0,30,0,0q�6    �� Orientation$ 
Horizontal=�6+   $��Center=�5z       � 	Resources 5|      &   Scoala3.Converters.ElevConverter  elevConverter��%   &	         5}      6,   5~      .+�5�      �� $��Adauga��5�      $	��120��5�      $��30��5�      $
��Bold"�5�      $��18(�5�      #��[  5�      ��5�      �� *
AddCommand+��5�      `� 5�       `� 	Converter# [ 6'   .1�5�      �� $ nameTextBox��6&   $
 Text�6@   �� 5�      $ idClasaTextBox��6&   $
 Text�6C   �� 5�      $ idElevTextBlock��6&   $
 Text�6D   5�      5�      �� 5�      $��Modifica��5�      $	��120��5�      $��30��5�      $
��Bold"�5�      $��18(�5�      #��[  5�      ��5�      �� *ModifyCommand+��5�      `� 5�      # [ 6'   .1�5�      �� $ nameTextBox��6&   $
 Text�6@   �� 5�      $ idClasaTextBox��6&   $
 Text�6C   �� 5�      $ idElevTextBlock��6&   $
 Text�6D   5�      5�      �� 5�      $��Sterge��5�      $	��120��5�      $��30��5�      $
��Bold"�5�      $��18(�5�      #��[  5�      ��5�      �� *DeleteCommand+��5�      `� 5�      # [ 6#   .1�5�      �� $ nameTextBox��6"   $
 Text�6<   �� 5�      $ idClasaTextBox��6"   $
 Text�6?   �� 5�      $ idElevTextBlock��6"   $
 Text�6@   5�      5�      5�      5�      5�      5�      
   M S B A M L   `   `   `  ����B  >Scoala3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Scoala3.ViewsScoala3.Views  5   	   5clr-namespace:Scoala3.ViewModelScoala3.ViewModel  5   	   7 clr-namespace:Scoala3.ConvertersScoala3.Converters  5	   	       Scoala3.Views.EditMaterii   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Scoala3.Views     5   	   /ctxclr-namespace:Scoala3.ViewModel     5   	   4convert clr-namespace:Scoala3.Converters     5	   	     � Title$  EditMaterii��5   	   $	��750��6   $	��500��6*   
������� � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      %  Scoala3.ViewModel.EditMateriiVM  5   
   .��5      � .+�5   
   �� $��Center=�6   $	��Top=�62   .+�5      �� $ ��Selectati numele materiei:��5      $
��Bold"�5      $��18(�5      �� 5      -   5        $��nameTextBox��5      ��5      ��  �� ElementName$ materiiGrid�� �� Path$ SelectedItem.Nume� �� UpdateSourceTrigger$ PropertyChanged=��� 5#      $��Id Materie:��5$      $
��Bold"�5%      $��18(�5&      �� 5)      -   5        $��idMaterieTextBlock��5*      
���������5+      �� $ materiiGrid��$ SelectedItem.Id�$ PropertyChanged=�5-      �� 50      $��Id Profesor:��51      $
��Bold"�52      $��18(�53      �� 56      -   5        $��idProfesorTextBlock��57      
���������58      �� $ profesorGrid��$ SelectedItem.Id�$ PropertyChanged=�5:      �� 5=      $��	Id Clasa:��5>      $
��Bold"�5?      $��18(�5@      �� 5C      -   5        $��idClasaTextBlock��5D      
���������5E      �� $ 	calseGrid��$ SelectedItem.Id�$ PropertyChanged=�5G      �� 5J      $��Selectati un profesor:��5K      $
��Bold"�5L      $��18(�5M      &   System.Windows.Controls.DataGrid  5O      -   5        $��profesorGrid��5O         AutoGenerateColumns .     
IsReadOnly . $��Visible=�5Q      $��90��5R      ��5P      �� *	Profesori+   Columns 5S      0  *System.Windows.Controls.DataGridTextColumn  5T      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *Id+  5U      $	 Nume Profesor��6)   
 6@   �� *Nume+  5V      $	 Specializare��6)   
 6?   �� *Specializare+  5W      $	 EsteDiriginte��6)   
 6@   �� *isDiriginte+5Y      �� 5[      $��Selectati clasa:��5\      $
��Bold"�5]      $��18(�5^        5a      -   5        $��	calseGrid��5a       .   . $��Visible=�5c      $��90��5d      ��5b      �� *Clase+ 5e        5f      $	 Id clasa��6)   
 6;   �� *Id+  5g      $	 
Nume clasa��6)   
 6=   �� *	NumeClasa+  5h      $	 Specializare��6)   
 6?   �� *Specializare+  5i      $	 Nume diriginte��6)   
 6A   �� *NumeDiriginte+  5j      $	 AnStudii��6)   
 6;   �� *
AnStudii+5l      �� 5n      $��Selectati Materia:��5o      $
��Bold"�5p      $��18(�5q        5t      -   5        $��materiiGrid��5t       .   . $��Visible=�5v      $��90��5w      ��5u      �� *	Materii+ 5x        5y      $	 
Id Materie��6)   
 6=   �� *Id+  5z      $	 Nume Materie��6)   
 6?   �� *Nume+  5{      $	 Id Profesor��6)   
 6>   �� *
IdProfesor+  5|      $	 Id Clasa��6)   
 6;   �� *	IdClasa+5~      �� 5�      $��0,30,0,0q�6    �� Orientation$ 
Horizontal=�6+   $��Center=�5�       � 	Resources 5�      )  #Scoala3.Converters.MateriiConverter   materiiConverter��%   &	          5�      6/   5�      .+�5�      �� $��Adauga��5�      $	��120��5�      $��30��5�      $
��Bold"�5�      $��18(�5�        NewGameButtonStyle#��[ 5�      ��5�      �� *
AddCommand+��5�      `� 5�       `� 	Converter# [  6'   .1�5�      �� $ nameTextBox��6&   $
 Text�6@   �� 5�      $ idMaterieTextBlock��6&   $
 Text�6G   �� 5�      $ idProfesorTextBlock��6&   $
 Text�6H   �� 5�      $ idClasaTextBlock��6&   $
 Text�6E   5�      5�      �� 5�      $��Modifica��5�      $	��120��5�      $��30��5�      $
��Bold"�5�      $��18(�5�      #��[ 5�      ��5�      �� *ModifyCommand+��5�      `� 5�      # [  6'   .1�5�      �� $ nameTextBox��6&   $
 Text�6@   �� 5�      $ idMaterieTextBlock��6&   $
 Text�6G   �� 5�      $ idProfesorTextBlock��6&   $
 Text�6H   �� 5�      $ idClasaTextBlock��6&   $
 Text�6E   5�      5�      �� 5�      $��Sterge��5�      $	��120��5�      $��30��5�      $
��Bold"�5�      $��18(�5�      #��[ 5�      ��5�      �� *DeleteCommand+��5�      `� 5�      # [  6'   .1�5�      �� $ nameTextBox��6&   $
 Text�6@   �� 5�      $ idMaterieTextBlock��6&   $
 Text�6G   �� 5�      $ idProfesorTextBlock��6&   $
 Text�6H   �� 5�      $ idClasaTextBlock��6&   $
 Text�6E   5�      5�      5�      5�      �� 5�   
   $
��Left=�6   $��Bottom=�60   .+�5�      �� $
��Back��5�      $	��100��5�      $��30��5�      $
��Bold"�5�      $��18(�5�      #��[ 5�      ��5�      �� *GoBackCommand+5�      �� 5�   
   $��Right=�6   $��Bottom=�61   .+�5�      �� $��Refresh��5�      $	��100��5�      $��30��5�      $
��Bold"�5�      $��18(�5�      #��[ 5�      ��5�      �� *RefreshCommand+5�      5�      5�      
   M S B A M L   `   `   `  ����B  >Scoala3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Scoala3.ViewsScoala3.Views  5   	   5clr-namespace:Scoala3.ViewModelScoala3.ViewModel  5   	   7 clr-namespace:Scoala3.ConvertersScoala3.Converters  5	   	   !    Scoala3.Views.EditProfesori   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Scoala3.Views     5   	   /ctxclr-namespace:Scoala3.ViewModel     5   	   4convert clr-namespace:Scoala3.Converters     5	   	     � Title$  EditProfesori��5   	   $	��600��6   $	��500��6,   
������� � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      '  !Scoala3.ViewModel.EditProfesoriVM  5   
   .��5      � .+�5   
   �� $��Center=�6   $	��Top=�62   .+�5      �� $��Selectati numele:��5      $
��Bold"�5      $��18(�5      �� 5      -   5        $��nameTextBox��5       ��5!      ��  �� ElementName$ profesorGrid�� �� Path$ SelectedItem.Nume� �� UpdateSourceTrigger$ PropertyChanged=��� 5%      $��Selectati specializarea:��5&      $
��Bold"�5'      $��18(�5(      �� 5+      -   5        $��specializareTextBox��5,      ��5-      �� $ profesorGrid��$ SelectedItem.Specializare�$ PropertyChanged=��� 51      $#��Profesorul este si diriginte?��52      $
��Bold"�53      $��18(�54      �� 57      -   5        $��isDiriginteTextBox��58      ��59      �� $ profesorGrid��$ SelectedItem.isDiriginte�$ PropertyChanged=��� 5=      $��Id Profesor:��5>      $
��Bold"�5?      $��18(�5@      �� 5C      -   5        $��idProfesorTextBlock��5D      
���������5E      �� $ profesorGrid��$ SelectedItem.Id�$ PropertyChanged=�5G      �� 5K      $��Selectati un profesor:��5L      $
��Bold"�5M      $��18(�5N      &   System.Windows.Controls.DataGrid  5P      -   5        $��profesorGrid��5P         AutoGenerateColumns .     
IsReadOnly . $��Visible=�5R      $��90��5S      ��5Q      �� *	Profesori+   Columns 5T      0  *System.Windows.Controls.DataGridTextColumn  5U      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *Id+  5V      $	 Nume Profesor��6)   
 6@   �� *Nume+  5W      $	 Specializare��6)   
 6?   �� *Specializare+  5X      $	 EsteDiriginte��6)   
 6@   �� *isDiriginte+5Z      �� 5\      $��0,30,0,0q�6    �� Orientation$ 
Horizontal=�6+   $��Center=�5]       � 	Resources 5_      *  $Scoala3.Converters.ProfesorConverter   profesorConverter��%   &	          5`      60   5a      .+�5d      �� $��Adauga��5e      $	��120��5f      $��30��5g      $
��Bold"�5h      $��18(�5i        NewGameButtonStyle#��[ 5j      ��5k      �� *
AddCommand+��5m      `� 5n       `� 	Converter# [  6'   .1�5o      �� $ idProfesorTextBlock��6&   $
 Text�6H   �� 5p      $ nameTextBox��6&   $
 Text�6@   �� 5q      $ specializareTextBox��6&   $
 Text�6H   �� 5r      $ isDiriginteTextBox��6&   $
 Text�6G   5s      5u      �� 5y      $��Modifica��5z      $	��120��5{      $��30��5|      $
��Bold"�5}      $��18(�5~      #��[ 5      ��5�      �� *ModifyCommand+��5�      `� 5�      # [  6'   .1�5�      �� $ idProfesorTextBlock��6&   $
 Text�6H   �� 5�      $ nameTextBox��6&   $
 Text�6@   �� 5�      $ specializareTextBox��6&   $
 Text�6H   �� 5�      $ isDiriginteTextBox��6&   $
 Text�6G   5�      5�      �� 5�      $��Sterge��5�      $	��120��5�      $��30��5�      $
��Bold"�5�      $��18(�5�      #��[ 5�      ��5�      �� *DeleteCommand+��5�      `� 5�      # [  6'   .1�5�      �� $ idProfesorTextBlock��6&   $
 Text�6H   �� 5�      $ nameTextBox��6&   $
 Text�6@   �� 5�      $ specializareTextBox��6&   $
 Text�6H   �� 5�      $ isDiriginteTextBox��6&   $
 Text�6G   5�      5�      5�      5�      �� 5�   
   $
��Left=�6   $��Bottom=�60   .+�5�      �� $
��Back��5�      $	��100��5�      $��30��5�      $
��Bold"�5�      $��18(�5�      #��[ 5�      ��5�      �� *GoBackCommand+5�      �� 5�   
   $��Right=�6   $��Bottom=�61   .+�5�      �� $��Refresh��5�      $	��100��5�      $��30��5�      $
��Bold"�5�      $��18(�5�      #��[ 5�      ��5�      �� *RefreshCommand+5�      5�      5�      
   M S B A M L   `   `   `  ����B  >Scoala3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Scoala3.ViewsScoala3.Views  5   	   5clr-namespace:Scoala3.ViewModelScoala3.ViewModel  5   
       Scoala3.Views.Note   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Scoala3.Views     5   	   /ctxclr-namespace:Scoala3.ViewModel     5   
     � Title$
  Note��5   	   $	��600��6   $	��500��6#   
������� � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5        Scoala3.ViewModel.NotaVM  5   
   .��5      � .+�5   
   �� $
��Left=�6   $��Bottom=�60   .+�5   
   �� $
��Back��5      $	��100��5      $��30��5      $
��Bold"�5      $��18(�5         NewGameButtonStyle#��[  5      ��5      �� *GoBackCommand+5      �� 5   
   $��Right=�6   $��Bottom=�61   .+�5       �� $��Refresh��5!      $	��100��5"      $��30��5#      $
��Bold"�5$      $��18(�5%      #��[  5&      ��5'      �� *RefreshCommand+5)      �� 5,   
   $��Center=�6   $	��Top=�62   .+�5.      �� $��Notele dumneavoastra:��5/      $
��Bold"�50      $��18(�51      &   System.Windows.Controls.DataGrid  54      -   5        $��noteGrid��54         AutoGenerateColumns .     
IsReadOnly . $��Visible=�56      $	��300��57      ��55      �� *Note+   Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *IdNota+  5:      $ Nume Materie��6)    6?   �� *NumeMaterie+  5;      $ EsteTeza��6)    6;   �� *isTeza+  5<      $
 Nota��6)    67   �� *valoareNota+  5=      $ Semestru��6)    6;   �� *
Semestru+5?      5A      5C      5D      
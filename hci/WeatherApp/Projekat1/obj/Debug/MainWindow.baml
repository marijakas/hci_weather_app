   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   D @Projekat1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Projekat1	Projekat1 5   	      Projekat1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   )localclr-namespace:Projekat1     5   	     � Title$  Weather Application��5	   	    � WindowStartupLocation$ CenterScreen=�5       � WindowState$ 	Maximized=�6*   $
��1080��6B   $
��2000��6P   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      ��5   
   �� 5       �� ImageSource$ Slike/grom2.jpg��6   .+�5    
   � $��0��6    � ColumnDefinitions 5!      �� 5#      $
��461* �6#   �� 5$      $
��535* �6#   .+�5&      �� $��1��6   
�������$��30(�6<   .��6J   *(Trenutna temperatura za izabrane gradove6t   &   System.Windows.Controls.DataGrid  5'      -   5        $��tabelaGlavna��5'      $��1��6+   $��25(�6�    J� Opacity$	 0.7Q�6�      
IsReadOnly . $
��Left=�6�   $	��289��6�   $	��988��6�   $	��Top=�6     AutoGenerateColumns .  $��	10,51,0,0q�6i  	 �� SelectedItem	 6<   �� 
 �� Path$
 SelektovaniGrad� �� Mode$ TwoWay=���6w   �� *TabelaVremeCurrent+   Columns 5)      4  .System.Windows.Controls.DataGridTemplateColumn  5*      -   5        
nazivGrada��,  &System.Windows.Controls.DataGridColumn   Header$ Naziv Grada��5*   A      CellTemplate 5+      �� 5,      .R�5-   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5.   &   �� $��slicica��6,   $��16��6;   $��16��6F   �� 5/   &   ��60   �� *naziv+50   #   51      53      0  *System.Windows.Controls.DataGridTextColumn  54      $ Datum��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *dt+  55      $ Trenutna temperatura��6)    6G   �� *temp+  57      $ Vazdusni pritisak��6)    6D   �� *
pressure+  58      $ Vlaznost vazduha��6)    6C   �� *
humidity+  59      $ 
Vidljivost��6)    6=   �� *
visibility+ � ContextMenu 5;      �� 5=      .@�5>      m� -   5        $��Obrisi��5>   #   63   5?         RowStyle 5A      �� 5B       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5C      ��  �� Property � �� �� Value
 ���� 68   �� 5D       � ��$ 0q�6<   5E      5I      �� 5J      -   5         ��Name$ listBox��5J   C   $��30(�6   $	 0.7Q�6%   $��0��63    �� Text$ Izaberite grad��6�   $��25,69,571,216q�6�   ��6T   �� *imenaGradova+ �� UpdateSourceTrigger$ Explicit=�	 6�   �� *selectedName+$ TwoWay=�6�   �� 5K      
�������$��20(�6,   $��25,0,543,157q�6:   $��46��6P   $��Bottom=�6\   .��6w   " Unesite broj dana za prikaz(1-8)6�   �� 5L      
�������$��30(�6,   $��50,0,571,281q�6:   $��59��6P   $��Bottom=�6\   .��6w   IZABERITE GRAD6�   �� 5N      -   5         ��Name$ itemNameTextBox��5N   $   $	 0.7Q�6   $��20(�6h   $��360,139,490,165q�6w   ��6�   �� $
 brojDana�$ TwoWay=�$ PropertyChanged=��� 5P      -   5         ��Name$ Dugme��5P      $	 0.7Q�6&   $��Prikazi��64   $��20(�6G   $
��Left=�6j   $��422,69,0,216q�6�    J� RenderTransformOrigin$ 
0.615,1.45&�6�   $	��116��6�   5R      � 5S   
   $��1��6    5T      �� 5U      $
��919* �6#   �� 5V      $��1073* �6#   .+�5Y      �� -   5        $��labelaDetaljna��5Y      $2��,Detaljna prognoza po satima za izabrani grad��6*   
�������$��30(�6y   $��1��6�   $y�Visible=�6�   $��Bottom=�6�   $
��Left=�6�   $��
10,0,0,271q�6�   $��52��6�   $	��666��6  6  �� 5Z      -   5         ��Name$ LabelaTemperatura��5Z   =   $��0��6   
�������$	��Top=�6Y   $
��Left=�6q   $��	370,0,0,0q�6�   $��55(�6�   $	��107��6�   $	��241��6�   �� 5\      -	   5        $ 
LabelaGrad��5\   H   $��0��6   $�� ��6$   
�������$��DemiBold"�6^   $��Bottom=�6t   $
��Left=�6�   $��10,-5,0,283q�6�   $��40(�6�   $	��278��6�   $��72��6�   �� 5]      -
   5        $ LabelaDrzava��5]   >   $��0��6   
�������$��DemiBold"�6V   $	��Top=�6l   $
��Left=�6�   $��	10,24,0,0q�6�   $��40(�6�   $��Italic$�6�   $	��271��6�   $��62��6�   �� 5^      -   5        $ LabelaVlaznost��5^   @   $��0��6   
�������$��DemiBold"�6Y   $��Bottom=�6o   $
��Left=�6�   $��370,0,0,150q�6�   $��20(�6�   $ 0.409,0.217&�6�   $	��342��6�   $��43��6�   �� 5_      -   5        $ LabelaOsecaj��5_   ?   $��0��6   
�������$��DemiBold"�6V   $	��Top=�6l   $��370,184,187,0q�6�   $��20(�6�   $ 2.173,-1.283&�6�   $��47��6�   �� 5`      -   5        $ LabelaPritisak��5`   @   $��0��6   
�������$��DemiBold"�6Y   $��Bottom=�6o   $
��Left=�6�   $��
370,0,0,72q�6�   $��20(�6�   $	��405��6�   $��47��6�   �� 5a      -   5        $��
LabelaOpis��5a   <   
�������$��0��6,   $��25(�6N   $��194,251,494,40q�6\   6v   �� 5b      -   5         ��Name$ ImageViewer1��5b      $	��184��6*   $
��Left=�66   $��163,116,0,67q�6Q   $ 0.374,0.553&�6g     5d      -   5        $��
TabelaSati��5d      $��1��6)   $y�Visible=�69   $��25(�6y   $	 0.7Q�6�    . $
��Left=�6�   $	��268��6�   $	��991��6�   $	��Top=�6�    .  $��	10,72,0,0q�6  ��6N   �� *TabelaVremeHourly+ 5e        5g      $ Vreme��6)    68   �� *dt+  5h      $ Trenutna temperatura��6)    6G   �� *temp+  5j      $ Vazdusni pritisak��6)    6D   �� *
pressure+  5k      $ Vlaznost vazduha��6)    6C   �� *
humidity+5n      5r      � 5u   
   $��2��6    5v      �� 5w      $��1607* �6#   �� 5x      $
��385* �6#   .+�5{      #   LiveCharts.Wpf.CartesianChart  -   5        $��	chart_day��5{   V   $��0��6"   $y�Visible=�6g   $��10,5,7,9q�6|   &    LiveCharts.Wpf.Charts.Base.Chart   Series 62   �� *SeriesCollection+   AxisY 5}      	   LiveCharts.Wpf.Axis	    	  Title$
  Temp��6   ! 	  LabelFormatter! 6,   �� *
YFormatter+6T   "   AxisX" 5�      	  $
  Time��6   # 	  Labels# 6,   �� *Labels+6H   5�      �� 5�      -   5        $ 	dugmePres��5�   1   $	 0.7Q�6   $��18(�6#   $��1��6F   $��Vazdusni pritisak��6V   $��0,220,228,53q�6�   �� 5�      -   5        $ dugneHum��5�   2   $	 0.7Q�6   $��18(�6$   $��1��6F   $��Vlaznost vazduha��6V   $��0,108,228,161q�6�   �� 5�      -   5        $ 	dugmeTemp��5�   2   $	 0.7Q�6   $��18(�6$   $��1��6G   $��Temperatura��6W   $��0,5,228,273q�6�   5�      5�      5�      
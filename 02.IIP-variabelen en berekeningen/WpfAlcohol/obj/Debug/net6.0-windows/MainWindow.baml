   M S B A M L   `   `   `  ����E  AWpfAlcohol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfAlcohol
WpfAlcohol  5   	       WpfAlcohol.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfAlcohol     5   	     � Title$  
WpfAlcohol��5   	   $	��750��6   $
��1000��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��53* �6   �� 5      $
��197* �6   .+�5   
   �� -   5         ��Name$ imgBier��5      $��fotos/bier.jpg��6!   $
��Left=�69   $	��118��6T   $��
44,100,0,0q�6a   $	��Top=�6u   $	��103��6�   �� 5   
   -   5        $ imgWijn��5      $��fotos/wijn.jpg��6!   $
��Left=�69   $	��134��6T   $��
44,261,0,0q�6a   $	��Top=�6u   $	��104��6�   �� 5   
   -   5        $ imgSterkeDrank��5      $��fotos/sterkeDrank.jpg��6(   $
��Left=�6G   $	��111��6b   $��
44,446,0,0q�6o   $	��Top=�6�   $	��103��6�   �� 5   
   $��Alcohol-gehalte��6   $
��Left=�6*   $��51��6E   $��	44,10,0,0q�6Q   $	��Top=�6d   $	��200��6|   $��24(�6�   $
��Bold"�6�   $��2��6�   �� 5   
   -   5         ��Name$ sldBier��5      $��1��6"    � Minimum$ 0Q�62    � Maximum$ 5Q�6>    � Value$ 0Q�6J    �� IsSnapToTickEnabled$
 True��6T    �� TickFrequency$ 1Q�6o   $
��Left=�6�   $��26��6�   $��	0,142,0,0q�6�   $	��Top=�6�   $	��481��6�   6�   �� 5   
   -   5        $ sldSterkeDrank��5      $��1��6)   $ 0Q�69   $ 5Q�6E   $ 0Q�6Q   $
 True��6[   $ 1Q�6v   $
��Left=�6�   $��26��6�   $��
10,484,0,0q�6�   $	��Top=�6�   $	��481��6�   6�   �� 5   
   -   5        $ sldWijn��5      $��1��6"   $ 0Q�62   $ 5Q�6>   $ 0Q�6J   $
 True��6T   $ 1Q�6o   $
��Left=�6�   $��26��6�   $��
10,311,0,0q�6�   $	��Top=�6�   $	��481��6�   6�   �� 5   
   -   5        	 ��Name$	 txtBier��5      $��1��6%   $
��Left=�65   $��42��6P   $��528,129,0,0q�6\   $
��Wrap=�6q   $	��Top=�6�   $	��230��6�   $��24(�6�   �� 5   
   -   5        $	 txtSterkeDrank��5      $��1��6,   $
��Left=�6<   $��42��6W   $��528,472,0,0q�6c   $
��Wrap=�6x   $	��Top=�6�   $	��230��6�   $��24(�6�   �� 5   
   -	   5        $	 txtWijn��5      $��1��6%   $
��Left=�65   $��42��6P   $��528,285,0,0q�6\   $
��Wrap=�6q   $	��Top=�6�   $	��230��6�   $��24(�6�   �� 5   
   -
   5        
 ��Name$
 rctAlcoholGehalte��5      $��0��60   $	��510��6=   $��50��6L   $��	9,610,0,0q�6X   
���   �$
��Left=�6z   $	��Top=�6�    J� RenderTransformOrigin$ 0.485,0.506&�6�   $��1��6�   z�5      V� 5      .~�5      ��  �� ScaleX$ +1Q�6%   �� 5      �� 5      T� 5       T� X$ +1Q�6)   5      5!      �� 5"   
   $��Alcohol-gehalte:��6   $��Center=�6+   $��	0,610,0,0q�6H   $	��Top=�6[   $��50��6s   $	��158��6   $��20(�6�   5$      5%      
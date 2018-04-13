using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour {

    public GameObject BlocoDeForaLvL3;
    public GameObject BlocoDeDentroLvL3;
    void Start()
    {
        Invoke("SpawnObject", 1);
        #region Fora
        #region  Esquerda

        Instantiate(BlocoDeForaLvL3, new Vector3(     0,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     0,   0,    1    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     0,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     0,   0,    3    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     0,   0,    4    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     0,   0,    5    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     0,   0,    6    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     0,   0,    7    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     0,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     0,   0,    9    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     0,   0,    10   ), Quaternion.identity);
        #endregion                                                    
                                                                      
        #region  Direita                                                      
                                                                      
        Instantiate(BlocoDeForaLvL3, new Vector3(    18,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    18,   0,    1    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    18,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    18,   0,    3    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    18,   0,    4    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    18,   0,    5    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    18,   0,    6    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    18,   0,    7    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    18,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    18,   0,    9    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    18,   0,    10   ), Quaternion.identity);
        #endregion                                                    
                                                                      
        #region Baixo                                                       
                                                                      
        Instantiate(BlocoDeForaLvL3, new Vector3(     1,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     2,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     3,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     4,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     5,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     6,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     7,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     8,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     9,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    10,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    11,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    12,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    13,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    14,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    15,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    16,   0,    0    ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    17,   0,    0    ), Quaternion.identity);
        #endregion                                                    
                                                                      
        #region Cima                                                        
                                                                      
        Instantiate(BlocoDeForaLvL3, new Vector3(     1,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     2,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     3,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     4,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     5,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     6,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     7,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     8,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(     9,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    10,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    11,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    12,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    13,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    14,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    15,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    16,   0,    10   ), Quaternion.identity);
        Instantiate(BlocoDeForaLvL3, new Vector3(    17,   0,    10   ), Quaternion.identity);
        #endregion	}                                                 
        #endregion

        #region Dentro                                                

        #region Esquerda
        #region ESQbaixo                                              
        Instantiate(BlocoDeDentroLvL3, new Vector3(   2,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   3,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   4,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   5,   0,    2    ), Quaternion.identity);
                                                                      
                                                                      
        #endregion                                                    
                                                                      
        #region ESQcima                                                
        Instantiate(BlocoDeDentroLvL3, new Vector3(   2,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   3,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   4,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   5,   0,    8    ), Quaternion.identity);
        #endregion                                                    
                                                             
        #region ESQmeio        

        Instantiate(BlocoDeDentroLvL3, new Vector3(   2,   0,    3    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   2,   0,    4    ), Quaternion.identity);
                                                      
        Instantiate(BlocoDeDentroLvL3, new Vector3(   2,   0,    6    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   2,   0,    7    ), Quaternion.identity);


        #endregion

        #endregion

        #region Meio
        #region Meio                                        
        Instantiate(BlocoDeDentroLvL3, new Vector3(   9,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   9,   0,    3    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   9,   0,    4    ), Quaternion.identity);
                                                                      
        Instantiate(BlocoDeDentroLvL3, new Vector3(   9,   0,    6    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   9,   0,    7    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   9,   0,    8    ), Quaternion.identity);
        #endregion                                                    
                                                                      
        #region MeioESQ                                               
        Instantiate(BlocoDeDentroLvL3, new Vector3(   7,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   8,   0,    2    ), Quaternion.identity);
                                                                      
        Instantiate(BlocoDeDentroLvL3, new Vector3(   7,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   8,   0,    8    ), Quaternion.identity);

        Instantiate(BlocoDeDentroLvL3, new Vector3(   7,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   8,   0,    2    ), Quaternion.identity);
                                                                      
        Instantiate(BlocoDeDentroLvL3, new Vector3(   7,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(   8,   0,    8    ), Quaternion.identity);
        #endregion

        #region MeioDir                                          
        Instantiate(BlocoDeDentroLvL3, new Vector3(  10,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  11,   0,    2    ), Quaternion.identity);

        Instantiate(BlocoDeDentroLvL3, new Vector3(  10,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  11,   0,    2    ), Quaternion.identity);
               
        
        Instantiate(BlocoDeDentroLvL3, new Vector3(  10,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  11,   0,    8    ), Quaternion.identity);
                                                                     
        Instantiate(BlocoDeDentroLvL3, new Vector3(  10,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  11,   0,    8    ), Quaternion.identity);
        #endregion

        #endregion

        #region Direita
        #region DIRbaixo               
        Instantiate(BlocoDeDentroLvL3, new Vector3(  13,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  14,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  15,   0,    2    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  16,   0,    2    ), Quaternion.identity);


        #endregion

        #region DIRcima                                               
        Instantiate(BlocoDeDentroLvL3, new Vector3(  13,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  14,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  15,   0,    8    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  16,   0,    8    ), Quaternion.identity);
        #endregion                                                    

        #region DIRmeio        

        Instantiate(BlocoDeDentroLvL3, new Vector3(  16,   0,    3    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  16,   0,    4    ), Quaternion.identity);
                                                      
        Instantiate(BlocoDeDentroLvL3, new Vector3(  16,   0,    6    ), Quaternion.identity);
        Instantiate(BlocoDeDentroLvL3, new Vector3(  16,   0,    7    ), Quaternion.identity);


        #endregion

        #endregion
        #endregion
    }
}

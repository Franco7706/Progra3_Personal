package pe.edu.pucp.softinv.db;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;


public class DBManagerTest {
    
    public DBManagerTest() {
    }

    @Test
    public void testGetInstance() {
        // La línea de abajo no funciona pues el DBManager es un singleton 
        // DBManager dbManager = new DBManager();
        
        System.out.println("testGetInstance");
        DBManager dbManager = DBManager.getInstance();
        assertNotNull(dbManager);
    }
    
}

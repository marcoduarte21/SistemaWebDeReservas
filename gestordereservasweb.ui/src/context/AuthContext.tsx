import { createContext } from "react";
import { User } from '../hooks/User';


interface AuthContext {
    user: User | null;
    setUser: (user: User | null) => void;
}


export const AuthContext = createContext<AuthContext>({
    user: null,
    setUser: () => { },
});